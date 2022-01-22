using System.Drawing.Imaging;
using System.Net;
using System.Runtime.InteropServices;

// oneAPI
using mfxChar = System.Char;
using mfxU8 = System.Byte;
using mfxU16 = System.UInt16;
using mfxU32 = System.UInt32;
using mfxU64 = System.UInt64;
using mfxI8 = System.SByte;
using mfxI16 = System.Int16;
using mfxI32 = System.Int32;
using mfxI64 = System.Int64;
using mfxF64 = System.Double;
using mfxIMPL = System.Int32;
using mfxF32 = System.Single;
using mfxHDL = System.IntPtr;
using mfxMemId = System.IntPtr;
using mfxThreadTask = System.IntPtr;

using OneAPIDotNet;
using OneAPIDotNet.VPL;

namespace HelloDecode
{

    internal class Program
    {

        #region Fields

        public static readonly string OUTPUT_FILE = "out.raw";
        public const int BITSTREAM_BUFFER_SIZE = 2000000;
        public const int MAJOR_API_VERSION_REQUIRED = 2;
        public const int MINOR_API_VERSION_REQUIRED = 2;

        #endregion

        #region Methods

        private static int Main(string[] args)
        {
            // Variables used for legacy and 2.x
            var isDraining = false;
            var isStillGoing = true;
            var framenum = 0u;
            MfxFrameSurface1 decSurfaceOut = null;
            var bitstream = new MfxBitstream();
            MfxSession session = null;
            var sts = MfxStatus.ErrorNone;
            var cliParams = new Params();
            var accelHandle = IntPtr.Zero;
            var decodeParams = new MfxVideoParam();

            // variables used only in 2.x version
            var cfg = new MfxConfig[3];
            var cfgVal = new MfxVariant[] { new MfxVariant(), new MfxVariant(), new MfxVariant() };
            MfxLoader loader = null;

            // Parse command line args to cliParams
            if (Util.ParseArgsAndValidate(args, cliParams, ParamGroup.PARAMS_DECODE) == false)
            {
                Usage();
                return 1; // return 1 as error code
            }

            try
            {
                using var source = Util.Verify(() => new FileStream(cliParams.InFileName, FileMode.Open, FileAccess.Read, FileShare.Read), "Could not open input file");
                using var sink = Util.Verify(() => new FileStream(OUTPUT_FILE, FileMode.Create, FileAccess.Write, FileShare.Write), "Could not create output file");

                // Initialize VPL session
                loader = Util.Verify(() => OneVPL.MFXLoad(), "MFXLoad failed -- is implementation in path?");

                // Implementation used must be the type requested from command line
                cfg[0] = OneVPL.MFXCreateConfig(loader);
                Util.Verify(() => cfg[0] != null, "MFXCreateConfig failed");

                sts = OneVPL.MFXSetConfigFilterProperty(cfg[0], "mfxImplDescription.Impl", cliParams.ImplValue);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "MFXSetConfigFilterProperty failed for Impl");

                // Implementation must provide an HEVC decoder
                cfg[1] = OneVPL.MFXCreateConfig(loader);
                Util.Verify(() => cfg[1] != null, "MFXCreateConfig failed");
                cfgVal[1].Type     = MfxVariantType.U32;
                cfgVal[1].Data.U32 = (uint)MfxCodec.HEVC;
                sts = OneVPL.MFXSetConfigFilterProperty(cfg[1], "mfxImplDescription.mfxDecoderDescription.decoder.CodecID", cfgVal[1]);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "MFXSetConfigFilterProperty failed for decoder CodecID");

                // Implementation must provide an HEVC decoder
                cfg[2] = OneVPL.MFXCreateConfig(loader);
                Util.Verify(() => cfg[2] != null, "MFXCreateConfig failed");
                cfgVal[2].Type     = MfxVariantType.U32;
                cfgVal[2].Data.U32 = (uint)Util.VplVersion(MAJOR_API_VERSION_REQUIRED, MINOR_API_VERSION_REQUIRED);
                sts = OneVPL.MFXSetConfigFilterProperty(cfg[2], "mfxImplDescription.ApiVersion.Version", cfgVal[2]);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "MFXSetConfigFilterProperty failed for API version");

                sts = OneVPL.MFXCreateSession(loader, 0, out session);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "Cannot create session -- no implementations meet selection criteria");

                // Print info about implementation loaded
                Util.ShowImplementationInfo(loader, 0);

                // Convenience function to initialize available accelerator(s)
                accelHandle = Util.InitAcceleratorHandle(session);

                // Prepare input bitstream and start decoding
                bitstream.MaxLength = BITSTREAM_BUFFER_SIZE;
                bitstream.Data =  Marshal.AllocCoTaskMem((int)(bitstream.MaxLength * sizeof(mfxU8)));
                Util.Verify(() => bitstream.Data != IntPtr.Zero, "Not able to allocate input buffer");
                bitstream.CodecId = (uint)MfxCodec.HEVC;

                // Pre-parse input stream
                sts = Util.ReadEncodedStream(bitstream, source);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "Error reading bitstream");

                decodeParams.Mfx.CodecId = (uint)MfxCodec.HEVC;
                decodeParams.IOPattern = (ushort)MfxIOPattern.OutSystemMemory;
                sts = OneVPL.MFXVideoDECODEDecodeHeader(session, bitstream, decodeParams);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "Error decoding header");

                // input parameters finished, now initialize decode
                sts = OneVPL.MFXVideoDECODEInit(session, decodeParams);
                Util.Verify(() => MfxStatus.ErrorNone == sts, "Error initializing decode");

                Console.WriteLine("Decoding {0} -> {1}", cliParams.InFileName, OUTPUT_FILE);

                Console.Write("Output colorspace: ");
                switch (decodeParams.Mfx.FrameInfo.FourCC) {
                    case MfxFourCC.I420: // CPU output
                        Console.WriteLine("I420 (aka yuv420p)");
                        break;
                    case MfxFourCC.NV12: // GPU output
                        Console.WriteLine("NV12");
                        break;
                    default:
                        Console.WriteLine("Unsupported color format");
                        throw new ApplicationException("Unsupported color format");
                }

                while (isStillGoing)
                {
                    // Load encoded stream if not draining
                    if (isDraining == false)
                    {
                        sts = Util.ReadEncodedStream(bitstream, source);
                        if (sts != MfxStatus.ErrorNone)
                            isDraining = true;
                    }

                    sts = OneVPL.MFXVideoDECODEDecodeFrameAsync(session,
                                                                (isDraining) ? null : bitstream,
                                                                null,
                                                                out decSurfaceOut,
                                                                out var syncp);

                    switch (sts)
                    {
                        case MfxStatus.ErrorNone:
                            do
                            {
                                sts = decSurfaceOut.FrameInterface.Synchronize(decSurfaceOut,
                                                                               Util.WAIT_100_MILLISECONDS);
                                if (MfxStatus.ErrorNone == sts)
                                {
                                    sts = Util.WriteRawFrameInternalMem(decSurfaceOut, sink);
                                    Util.Verify(() => MfxStatus.ErrorNone == sts, "Could not write decode output");

                                    framenum++;
                                }
                            } while (sts == MfxStatus.WarningInExecution);
                            break;
                        case MfxStatus.ErrorMoreData:
                            // The function requires more bitstream at input before decoding can
                            // proceed
                            if (isDraining)
                                isStillGoing = false;
                            break;
                        case MfxStatus.ErrorMoreSurface:
                            // The function requires more frame surface at output before decoding
                            // can proceed. This applies to external memory allocations and should
                            // not be expected for a simple internal allocation case like this
                            break;
                        case MfxStatus.ErrorDeviceLost:
                            // For non-CPU implementations,
                            // Cleanup if device is lost
                            break;
                        case MfxStatus.WarningDeviceBusy:
                            // For non-CPU implementations,
                            // Wait a few milliseconds then try again
                            break;
                        case MfxStatus.WarningVideoParamChanged:
                            // The decoder detected a new sequence header in the bitstream.
                            // Video parameters may have changed.
                            // In external memory allocation case, might need to reallocate the
                            // output surface
                            break;
                        case MfxStatus.ErrorIncompatibleVideoParam:
                            // The function detected that video parameters provided by the
                            // application are incompatible with initialization parameters. The
                            // application should close the component and then reinitialize it
                            break;
                        case MfxStatus.ErrorReAllocSurface:
                            // Bigger surface_work required. May be returned only if
                            // mfxInfoMFX::EnableReallocRequest was set to ON during initialization.
                            // This applies to external memory allocations and should not be
                            // expected for a simple internal allocation case like this
                            break;
                        default:
                            Console.WriteLine("unknown status {0}", sts);
                            isStillGoing = false;
                            break;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                Console.WriteLine($"Decoded {framenum} frames");

                if (session != null)
                    OneVPL.MFXVideoDECODEClose(session);
                if (session != null)
                    OneVPL.MFXClose(session);

                if (bitstream.Data != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(bitstream.Data);

                if (loader != null)
                    OneVPL.MFXUnload(loader);
            }

            return 0;
        }

        #region Helpers

        private static void Usage()
        {
            Console.WriteLine("");
            Console.WriteLine("   Usage  :  hello-decode ");
            Console.WriteLine("");
            Console.WriteLine("     -sw/-hw        use software or hardware implementation");
            Console.WriteLine("     -i             input file name (HEVC elementary stream)");
            Console.WriteLine("");
            Console.WriteLine("   Example:  hello-decode -sw  -i in.h265");
            Console.WriteLine("");
            Console.WriteLine($"   To view:  ffplay -f rawvideo -pixel_format yuv420p -video_size [width]x[height] {OUTPUT_FILE}");
            Console.WriteLine("");
            Console.WriteLine($" * Decode HEVC/H265 elementary stream to raw frames in {OUTPUT_FILE}");
            Console.WriteLine("");
            Console.WriteLine("   CPU native color format is I420/yuv420p.  GPU native color format is NV12");
            return;
        }

        #endregion

        #endregion

    }

}
