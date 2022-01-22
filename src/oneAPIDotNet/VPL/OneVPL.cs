using System;
using System.Text;

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

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Provides the methods of oneVPL.
    /// </summary>
    public static partial class OneVPL
    {

        #region Methods

        #region MfxDispatcher

        public static MfxConfig MFXCreateConfig(MfxLoader loader)
        {
            if (loader == null)
                throw new ArgumentNullException(nameof(loader));

            loader.ThrowIfDisposed();

            var config = NativeMethods.oneapi_vpl_MFXCreateConfig(loader.NativePtr);
            return new MfxConfig(config);
        }

        public static MfxStatus MFXCreateSession(MfxLoader loader, uint i, out MfxSession session)
        {
            if (loader == null)
                throw new ArgumentNullException(nameof(loader));

            session = null;
            loader.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXCreateSession(loader.NativePtr, i, out var ret);
            if (ret != IntPtr.Zero)
                session = new MfxSession(ret);
            return status;
        }

        public static MfxStatus MFXDispReleaseImplDescription<T>(MfxLoader loader, T hdl)
            where T: OneAPIObject
        {
            if (loader == null)
                throw new ArgumentNullException(nameof(loader));
            if (hdl == null)
                throw new ArgumentNullException(nameof(hdl));

            loader.ThrowIfDisposed();
            hdl.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXDispReleaseImplDescription(loader.NativePtr, hdl.NativePtr);
            return status;
        }

        public static MfxStatus MFXEnumImplementations<T>(MfxLoader loader,
                                                          uint i,
                                                          MfxImplCapsDeliveryFormat format,
                                                          out T obj)
            where T: OneAPIObject
        {
            if (loader == null)
                throw new ArgumentNullException(nameof(loader));

            obj = default(T);
            loader.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXEnumImplementations(loader.NativePtr, i, format, out var ret);
            if (ret != IntPtr.Zero)
            {
                switch (format)
                {
                    case MfxImplCapsDeliveryFormat.ImplDescription:
                        obj = new MfxImplDescription(ret, true) as T;
                        break;
                    case MfxImplCapsDeliveryFormat.ImplementedFunctions:
                        break;
                }
            }

            return status;
        }

        public static MfxLoader MFXLoad()
        {
            var loader = NativeMethods.oneapi_vpl_MFXLoad();
            return new MfxLoader(loader);
        }

        public static MfxStatus MFXSetConfigFilterProperty(MfxConfig config, string name, MfxVariant variant)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (variant == null)
                throw new ArgumentNullException(nameof(variant));

            config.ThrowIfDisposed();
            variant.ThrowIfDisposed();

            var nameBytes = Encoding.ASCII.GetBytes(name);
            var status = NativeMethods.oneapi_vpl_MFXSetConfigFilterProperty(config.NativePtr, nameBytes, (uint)nameBytes.Length, variant.NativePtr);
            return status;
        }

        public static void MFXUnload(MfxLoader loader)
        {
            if (loader == null)
                throw new ArgumentNullException(nameof(loader));

            loader.ThrowIfDisposed();

            NativeMethods.oneapi_vpl_MFXUnload(loader.NativePtr);

            loader.Dispose();
        }

        #endregion

        #region MfxSession
        
        public static MfxStatus MFXClose(MfxSession session)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));

            session.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXClose(session.NativePtr);
            return status;
        }

        public static MfxStatus MFXInit(MfxImpl impl, MfxVersion version, out MfxSession session)
        {
            var versionPtr = IntPtr.Zero;
            if (version != null)
            {
                version.ThrowIfDisposed();
                versionPtr = version.NativePtr;
            }

            var status = NativeMethods.oneapi_vpl_MFXInit((int)impl, versionPtr, out var handle);
            session = new MfxSession(handle);
            return status;
        }

        public static MfxStatus MFXQueryIMPL(MfxSession session, out mfxIMPL impl)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));

            session.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXQueryIMPL(session.NativePtr, out impl);
            return status;
        }

        #endregion

        #region  MfxVideo
        
        public static MfxStatus MFXVideoDECODEInit(MfxSession session,
                                                   MfxVideoParam param)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            if (param == null)
                throw new ArgumentNullException(nameof(param));

            session.ThrowIfDisposed();
            param.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXVideoDECODE_Init(session.NativePtr, param.NativePtr);
            return status;
        }
        
        public static MfxStatus MFXVideoDECODEClose(MfxSession session)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));

            session.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXVideoDECODE_Close(session.NativePtr);
            return status;
        }
                                                                                  
        public static MfxStatus MFXVideoDECODEDecodeFrameAsync(MfxSession session,
                                                               MfxBitstream bitstream,
                                                               MfxFrameSurface1 surfaceWork,
                                                               out MfxFrameSurface1 surfaceOut,
                                                               out MfxSyncPoint syncp)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            
            surfaceOut = null;
            syncp = null;

            session.ThrowIfDisposed();
            if (bitstream != null)
                bitstream.ThrowIfDisposed();
            if (surfaceWork != null)
                surfaceWork.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXVideoDECODE_DecodeFrameAsync(session.NativePtr,
                                                                                  bitstream != null ? bitstream.NativePtr : IntPtr.Zero,
                                                                                  surfaceWork != null ? surfaceWork.NativePtr : IntPtr.Zero,
                                                                                  out var ret,
                                                                                  out var sync);
            if (ret != IntPtr.Zero) 
                surfaceOut = new MfxFrameSurface1(ret, false); // ToDo: Can I pass false?
            if (sync != IntPtr.Zero)
                syncp = new MfxSyncPoint(sync);
            return status;
        }

        public static MfxStatus MFXVideoDECODEDecodeHeader(MfxSession session,
                                                           MfxBitstream bitstream,
                                                           MfxVideoParam param)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            if (bitstream == null)
                throw new ArgumentNullException(nameof(bitstream));
            if (param == null)
                throw new ArgumentNullException(nameof(param));

            session.ThrowIfDisposed();
            bitstream.ThrowIfDisposed();
            param.ThrowIfDisposed();

            var status = NativeMethods.oneapi_vpl_MFXVideoDECODE_DecodeHeader(session.NativePtr, bitstream.NativePtr, param.NativePtr);
            return status;
        }

        #endregion

        #endregion

        #region Properties

        #region MfxDefs

        public static uint MFXLegacyVersion => NativeMethods.oneapi_vpl_get_MFX_LEGACY_VERSION();

        public static uint MFXVersion => NativeMethods.oneapi_vpl_get_MFX_VERSION();

        public static uint MFXVersionMajor => NativeMethods.oneapi_vpl_get_MFX_VERSION_MAJOR();

        public static uint MFXVersionMinor => NativeMethods.oneapi_vpl_get_MFX_VERSION_MINOR();

        #endregion

        private static Encoding _Encoding = Encoding.UTF8;

        public static Encoding Encoding
        {
            get => _Encoding;
            set => _Encoding = value ?? Encoding.UTF8;
        }

        #endregion

    }

}