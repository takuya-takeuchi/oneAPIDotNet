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
    /// Describes frame buffer pointers. This class cannot be inherited.
    /// </summary>
    public sealed class MfxFrameData : OneAPIObject
    {

        #region Constructors

        internal MfxFrameData(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public IntPtr A
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_A(this.NativePtr);
            }
        }

        public IntPtr B
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_B(this.NativePtr);
            }
        }

        public IntPtr Cb
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_Cb(this.NativePtr);
            }
        }

        public IntPtr CbCr
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_CbCr(this.NativePtr);
            }
        }

        public IntPtr Cr
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_Cr(this.NativePtr);
            }
        }

        public IntPtr CrCb
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_CrCb(this.NativePtr);
            }
        }

        public IntPtr G
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_G(this.NativePtr);
            }
        }

        public mfxU16 Pitch
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_Pitch(this.NativePtr);
            }
        }

        public IntPtr R
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_R(this.NativePtr);
            }
        }

        public IntPtr U
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_U(this.NativePtr);
            }
        }

        public IntPtr U16
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_U16(this.NativePtr);
            }
        }

        public IntPtr UV
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_UV(this.NativePtr);
            }
        }

        public IntPtr V
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_V(this.NativePtr);
            }
        }

        public IntPtr V16
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_V16(this.NativePtr);
            }
        }

        public IntPtr VU
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_VU(this.NativePtr);
            }
        }

        public IntPtr Y
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_Y(this.NativePtr);
            }
        }

        public IntPtr Y16
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameData_get_Y16(this.NativePtr);
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

            NativeMethods.oneapi_vpl_mfxFrameInfo_delete(this.NativePtr);
        }

        #endregion

    }

}