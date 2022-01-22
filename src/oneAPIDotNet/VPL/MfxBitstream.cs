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
    /// Defines the buffer that holds compressed video data. This class cannot be inherited.
    /// </summary>
    public sealed class MfxBitstream : OneAPIObject
    {

        #region Constructors

        public MfxBitstream()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxBitstream_new();
        }

        #endregion

        #region Properties

        public mfxU32 CodecId
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_CodecId(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_CodecId(this.NativePtr, value);
            }
        }

        public IntPtr Data
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_Data(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_Data(this.NativePtr, value);
            }
        }

        public mfxU16 DataFlag
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_DataFlag(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_DataFlag(this.NativePtr, value);
            }
        }

        public mfxU32 DataLength
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_DataLength(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_DataLength(this.NativePtr, value);
            }
        }

        public mfxU32 DataOffset
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_DataOffset(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_DataOffset(this.NativePtr, value);
            }
        }

        public mfxI64 DecodeTimeStamp
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_DecodeTimeStamp(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_DecodeTimeStamp(this.NativePtr, value);
            }
        }

        public mfxU16 FrameType
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_FrameType(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_FrameType(this.NativePtr, value);
            }
        }

        public mfxU32 MaxLength
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_MaxLength(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_MaxLength(this.NativePtr, value);
            }
        }

        public mfxU16 PicStruct
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_PicStruct(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_PicStruct(this.NativePtr, value);
            }
        }

        public mfxU64  TimeStamp
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxBitstream_get_TimeStamp(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxBitstream_set_TimeStamp(this.NativePtr, value);
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

            NativeMethods.oneapi_vpl_mfxBitstream_delete(this.NativePtr);
        }

        #endregion

    }

}