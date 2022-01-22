using System.Drawing.Imaging;
using System.Net;
using System.Runtime.InteropServices;

using OneAPIDotNet;
using OneAPIDotNet.VPL;

// oneAPI
using mfxU16 = System.UInt16;
using mfxU32 = System.UInt32;
using mfxI32 = System.Int32;
using mfxIMPL = System.Int32;

namespace HelloDecode
{


    internal sealed class Params
    {

        public Params()
        {
            this.ImplValue = new MfxVariant();
        }

        public MfxImpl Impl
        {
            get;
            set;
        }

        public MfxVariant ImplValue
        {
            get;
        }

        public string InFileName
        {
            get;
            set;
        }

        public string InModelName
        {
            get;
            set;
        }

        public mfxU16 SourceWidth
        {
            get;
            set;
        }

        public mfxU16 SourceHeight
        {
            get;
            set;
        }

    }

    internal enum ParamGroup
    {

        PARAMS_CREATESESSION = 0,

        PARAMS_DECODE,

        PARAMS_ENCODE,

        PARAMS_VPP,

        PARAMS_TRANSCODE

    }
    internal class Util
    {

        #region Fields

        public const int WAIT_100_MILLISECONDS = 100;

        public const int MAX_PATH = 260;
        public const int MAX_WIDTH = 3840;
        public const int MAX_HEIGHT = 2160;

        #endregion

        #region Methods

        public static IntPtr InitAcceleratorHandle(MfxSession session)
        {
            var sts = OneVPL.MFXQueryIMPL(session, out var impl);
            if (sts != MfxStatus.ErrorNone)
                return IntPtr.Zero;

#if LIBVA_SUPPORT
            if ((impl & MFX_IMPL_VIA_VAAPI) == MFX_IMPL_VIA_VAAPI)
            {
                VADisplay va_dpy = NULL;
                int fd;
                // initialize VAAPI context and set session handle (req in Linux)
                fd = open("/dev/dri/renderD128", O_RDWR);
                if (fd >= 0) {
                    va_dpy = vaGetDisplayDRM(fd);
                    if (va_dpy) {
                        int major_version = 0, minor_version = 0;
                        if (VA_STATUS_SUCCESS == vaInitialize(va_dpy, &major_version, &minor_version)) {
                            MFXVideoCORE_SetHandle(session,
                                                static_cast<mfxHandleType>(MFX_HANDLE_VA_DISPLAY),
                                                va_dpy);
                        }
                    }
                }
                return va_dpy;
            }
#endif

            return IntPtr.Zero;
        }

        public static bool ParseArgsAndValidate(string[] args, Params @params, ParamGroup group)
        {
            @params.Impl = MfxImpl.Software;
            @params.ImplValue.Type     = MfxVariantType.U32;
            @params.ImplValue.Data.U32 = (uint)MfxImpl.Software;

            for (var idx = 0; idx < args.Length;)
            {
                // all switches must start with '-'
                if (!args[idx].StartsWith("-"))
                {
                    Console.WriteLine($"ERROR - invalid argument: {args[idx]}");
                    return false;
                }

                // switch string, starting after the '-'
                var s = args[idx].Substring(1, args[idx].Length - 1);
                idx++;

                // search for match
                switch (s)
                {
                    case "i":
                        @params.InFileName = ValidateFileName(args[idx++]);
                        if (string.IsNullOrWhiteSpace(@params.InFileName))
                        {
                            return false;
                        }
                        break;
                    case "m":
                        @params.InModelName = ValidateFileName(args[idx++]);
                        if (string.IsNullOrWhiteSpace(@params.InModelName))
                        {
                            return false;
                        }
                        break;
                    case "w":
                        if (!ValidateSize(args[idx++], out var width, MAX_WIDTH))
                            return false;
                        @params.SourceWidth = width;
                        break;
                    case "h":
                        if (!ValidateSize(args[idx++], out var height, MAX_HEIGHT))
                            return false;
                        @params.SourceHeight = height;
                        break;
                    case "hw":
                        @params.Impl = MfxImpl.Hardware;
                        @params.ImplValue.Data.U32 = (uint)MfxImplType.Hardware;
                        break;
                    case "sw":
                        @params.Impl = MfxImpl.Software;
                        @params.ImplValue.Data.U32 = (uint)MfxImplType.Software;
                        break;
                }
            }

            // input file required by all except createsession
            if ((group != ParamGroup.PARAMS_CREATESESSION) && string.IsNullOrWhiteSpace(@params.InFileName))
            {
                Console.WriteLine("ERROR - input file name (-i) is required");
                return false;
            }

            // VPP and encode samples require an input resolution
            if (ParamGroup.PARAMS_VPP == group || ParamGroup.PARAMS_ENCODE == group)
            {
                if (@params.SourceWidth == 0 || @params.SourceHeight == 0)
                {
                    Console.WriteLine("ERROR - source width/height required");
                    return false;
                }
            }

            return true;
        }

        public unsafe static MfxStatus ReadEncodedStream(MfxBitstream bitstream, FileStream stream)
        {
            var p0 = bitstream.Data;
            var p1 = IntPtr.Add(bitstream.Data, (int)bitstream.DataOffset);
            if (bitstream.DataOffset > bitstream.MaxLength - 1)
            {
                return MfxStatus.ErrorNotEnoughBuffer;
            }

            if (bitstream.DataLength + bitstream.DataOffset > bitstream.MaxLength)
            {
                return MfxStatus.ErrorNotEnoughBuffer;
            }

            byte* pp0 = (byte*)p0;
            byte* pp1 = (byte*)p1;
            for (var i = 0; i < bitstream.DataLength; i++)
            {
                *(pp0++) = *(pp1++);
            }

            bitstream.DataOffset = 0;
            byte[] buffer = new byte[bitstream.MaxLength - bitstream.DataLength];
            var dst = IntPtr.Add(bitstream.Data, (int)bitstream.DataLength);
            bitstream.DataLength += (uint)stream.Read(buffer, 0, (int)(bitstream.MaxLength - bitstream.DataLength));
            Marshal.Copy(buffer, 0, dst, buffer.Length);
            if (bitstream.DataLength == 0)
                return MfxStatus.ErrorMoreData;

            return MfxStatus.ErrorNone;
        }

        public static void ShowImplementationInfo(MfxLoader loader, mfxU32 implnum)
        {            
            // Loads info about implementation at specified list location
            var sts = OneVPL.MFXEnumImplementations<MfxImplDescription>(loader, implnum, MfxImplCapsDeliveryFormat.ImplDescription, out var idesc);
            if (idesc == null || sts != MfxStatus.ErrorNone)
                return;

            Console.WriteLine("Implementation details:");
            Console.WriteLine("  ApiVersion:           {0}.{1}  ", idesc.ApiVersion.Major, idesc.ApiVersion.Minor);
            Console.WriteLine("  Implementation type:  {0}", (idesc.Impl == MfxImplType.Software) ? "SW" : "HW");
            Console.Write("  AccelerationMode via: ");
            switch (idesc.AccelerationMode)
            {
                case MfxAccelerationMode.NotApplicable:
                    Console.WriteLine("NA ");
                    break;
                case MfxAccelerationMode.ViaDirect3D9:
                    Console.WriteLine("D3D9");
                    break;
                case MfxAccelerationMode.ViaDirect3D11:
                    Console.WriteLine("D3D11");
                    break;
                case MfxAccelerationMode.ViaVAAPI:
                    Console.WriteLine("VAAPI");
                    break;
                case MfxAccelerationMode.ViaVAAPIDRMModeSet:
                    Console.WriteLine("VAAPI_DRM_MODESET");
                    break;
                case MfxAccelerationMode.ViaVAAPIGLX:
                    Console.WriteLine("VAAPI_GLX");
                    break;
                case MfxAccelerationMode.ViaVAAPIX11:
                    Console.WriteLine("VAAPI_X11");
                    break;
                case MfxAccelerationMode.ViaVAAPIWayland:
                    Console.WriteLine("VAAPI_WAYLAND");
                    break;
                case MfxAccelerationMode.ViaHDDLUnite:
                    Console.WriteLine("HDDLUNITE");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            OneVPL.MFXDispReleaseImplDescription(loader, idesc);
        }

        public static string ValidateFileName(string @in)
        {
            if (!string.IsNullOrWhiteSpace(@in))
            {
                if (@in.Length > MAX_PATH)
                    return null;
            }

            return @in;
        }

        public static bool ValidateSize(string @in, out mfxU16 vsize, mfxU32 vmax)
        {
            if (!string.IsNullOrWhiteSpace(@in))
            {
                if (mfxU16.TryParse(@in, out vsize) && vsize <= vmax)
                    return true;
            }

            vsize = 0;
            return false;
        }

        public static T Verify<T>(Func<T> func, string message)
        {
            try
            {
                return func();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(message);
                throw new ApplicationException(ex.Message);
            }
        }

        public static void Verify(Func<bool> func, string message)
        {
            if (!func())
            {
                Console.WriteLine(message);
                throw new ApplicationException();
            }
        }

        public static int VplVersion(int major, int minor)
        {
            return (major << 16 | minor);
        }
        
        public static MfxStatus WriteRawFrame(MfxFrameSurface1 surface, FileStream f)
        {
            mfxU16 i, pitch;
            var info = surface.Info;
            var data = surface.Data;

            var w = info.Width;
            var h = info.Height;

            // write the output to disk
            switch (info.FourCC)
            {
                case MfxFourCC.I420:
                    {
                        var buffer = new byte[w];

                        // Y
                        pitch = data.Pitch;
                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.Y, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                        // U
                        pitch /= 2;
                        h /= 2;
                        w /= 2;

                        buffer = new byte[w];

                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.U, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                        // V
                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.V, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                    }
                    break;
                case MfxFourCC.NV12:
                    {
                        var buffer = new byte[w];

                        // Y
                        pitch = data.Pitch;
                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.Y, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                        // UV
                        h /= 2;
                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.UV, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                    }
                    break;
                case MfxFourCC.RGB4:
                    {
                        var buffer = new byte[w];
                        
                        // Y
                        pitch = data.Pitch;
                        for (i = 0; i < h; i++)
                        {
                            Marshal.Copy(IntPtr.Add(data.B, (int)(i * pitch)), buffer, 0, w);
                            f.Write(buffer, 0, buffer.Length);
                        }
                    }
                    break;
                default:
                    return MfxStatus.ErrorUnsupported;
            }

            return MfxStatus.ErrorNone;
        }

        public static MfxStatus WriteRawFrameInternalMem(MfxFrameSurface1 surface, FileStream f)
        {
            var sts = surface.FrameInterface.Map(surface, MfxMemoryFlags.Read);
            if (sts != MfxStatus.ErrorNone)
            {
                Console.WriteLine("mfxFrameSurfaceInterface->Map failed ({0})", sts);
                return sts;
            }

            sts = WriteRawFrame(surface, f);
            if (sts != MfxStatus.ErrorNone)
            {
                Console.WriteLine("Error in WriteRawFrame");
                return sts;
            }

            sts = surface.FrameInterface.Unmap(surface);
            if (sts != MfxStatus.ErrorNone)
            {
                Console.WriteLine("mfxFrameSurfaceInterface->Unmap failed ({0})", sts);
                return sts;
            }

            sts = surface.FrameInterface.Release(surface);
            if (sts != MfxStatus.ErrorNone)
            {
                Console.WriteLine("mfxFrameSurfaceInterface->Release failed ({0})", sts);
                return sts;
            }

            return sts;
        }

        #endregion

    }

}
