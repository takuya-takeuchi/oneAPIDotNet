using System;

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
    /// Specifies configurations for decoding, encoding, and transcoding processes. This class cannot be inherited.
    /// </summary>
    public sealed class MfxInfoMFX : OneAPIObject
    {

        #region Constructors

        public MfxInfoMFX()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxInfoMFX_new();
        }

        internal MfxInfoMFX(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public mfxU16 BRCParamMultiplier
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_BRCParamMultiplier(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_BRCParamMultiplier(this.NativePtr, value);
            }
        }

        public mfxU32 CodecId
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_CodecId(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_CodecId(this.NativePtr, value);
            }
        }

        public mfxU16 CodecLevel
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_CodecLevel(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_CodecLevel(this.NativePtr, value);
            }
        }

        public mfxU16 CodecProfile
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_CodecProfile(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_CodecProfile(this.NativePtr, value);
            }
        }

        public MfxFrameInfo FrameInfo
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxInfoMFX_get_FrameInfo(this.NativePtr);
                return new MfxFrameInfo(ret, false);
            }
        }

        public mfxU16 LowPower
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_LowPower(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_LowPower(this.NativePtr, value);
            }
        }

        public mfxU16 NumThread
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxInfoMFX_get_NumThread(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxInfoMFX_set_NumThread(this.NativePtr, value);
            }
        }

        #endregion

        #region Overrides 

        /// <summary>
        /// Releases all unmanaged resources.
        /// </summary>
        protected override void DisposeUnmanaged()
        {
            base.DisposeUnmanaged();

            if (this.NativePtr == IntPtr.Zero)
                return;

            NativeMethods.oneapi_vpl_mfxInfoMFX_delete(this.NativePtr);
        }

        #endregion

    }

}