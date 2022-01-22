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
    /// Describes the Configuration parameters for encoding, decoding, transcoding, and video processing. This class cannot be inherited.
    /// </summary>
    public sealed class MfxVideoParam : OneAPIObject
    {

        #region Constructors

        public MfxVideoParam()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxVideoParam_new();
        }

        #endregion

        #region Properties

        public mfxU32 AllocId
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVideoParam_get_AllocId(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVideoParam_set_AllocId(this.NativePtr, value);
            }
        }

        public mfxU16 AsyncDepth
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVideoParam_get_AsyncDepth(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVideoParam_set_AsyncDepth(this.NativePtr, value);
            }
        }

        public mfxU16 IOPattern
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVideoParam_get_IOPattern(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVideoParam_set_IOPattern(this.NativePtr, value);
            }
        }

        public MfxInfoMFX Mfx
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxVideoParam_get_mfx(this.NativePtr);
                return new MfxInfoMFX(ret, false);
            }
        }

        public mfxU16 NumExtParam
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVideoParam_get_NumExtParam(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVideoParam_set_NumExtParam(this.NativePtr, value);
            }
        }

        public mfxU16 Protected
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVideoParam_get_Protected(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVideoParam_set_Protected(this.NativePtr, value);
            }
        }

        // public MfxInfoVPP Vpp
        // {
        //     get
        //     {
        //         this.ThrowIfDisposed();
        //         return NativeMethods.oneapi_vpl_mfxVideoParam_get_vpp(this.NativePtr);
        //     }
        // }

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

            NativeMethods.oneapi_vpl_mfxVideoParam_delete(this.NativePtr);
        }

        #endregion

    }

}