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
    /// Specifies properties of video frames. This class cannot be inherited.
    /// </summary>
    public sealed class MfxFrameInfo : OneAPIObject
    {

        #region Constructors

        public MfxFrameInfo()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxFrameInfo_new();
        }

        internal MfxFrameInfo(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public mfxU16 AspectRatioH
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_AspectRatioH(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_AspectRatioH(this.NativePtr, value);
            }
        }

        public mfxU16 AspectRatioW
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_AspectRatioW(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_AspectRatioW(this.NativePtr, value);
            }
        }

        public mfxU16 BitDepthChroma
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_BitDepthChroma(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_BitDepthChroma(this.NativePtr, value);
            }
        }

        public mfxU16 BitDepthLuma
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_BitDepthLuma(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_BitDepthLuma(this.NativePtr, value);
            }
        }

        public mfxU16 ChannelId
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_ChannelId(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_ChannelId(this.NativePtr, value);
            }
        }

        public mfxU16 ChromaFormat
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_ChromaFormat(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_ChromaFormat(this.NativePtr, value);
            }
        }

        public MfxFourCC FourCC
        {
            get
            {
                this.ThrowIfDisposed();
                return (MfxFourCC)NativeMethods.oneapi_vpl_mfxFrameInfo_get_FourCC(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_FourCC(this.NativePtr, (mfxU32)value);
            }
        }

        public mfxU32 FrameRateExtD
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_FrameRateExtD(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_FrameRateExtD(this.NativePtr, value);
            }
        }

        public mfxU32 FrameRateExtN
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_FrameRateExtN(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_FrameRateExtN(this.NativePtr, value);
            }
        }

        public mfxU16 Height
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_Height(this.NativePtr);
            }
        }

        public mfxU16 PicStruct
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_PicStruct(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_PicStruct(this.NativePtr, value);
            }
        }

        public mfxU16 Shift
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_Shift(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxFrameInfo_set_Shift(this.NativePtr, value);
            }
        }

        public mfxU16 Width
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxFrameInfo_get_Width(this.NativePtr);
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