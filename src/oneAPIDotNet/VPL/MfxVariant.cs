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
    /// Describes the enumerator data types for mfxVariant type. This class cannot be inherited.
    /// </summary>
    public sealed class MfxVariant : OneAPIObject
    {

        #region Constructors

        public MfxVariant()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxVariant_new();
        }

        #endregion

        #region Properties

        public ValueDataHolder Data
        {
            get
            {
                this.ThrowIfDisposed();
                return new ValueDataHolder(this);
            }
        }

        public MfxVariantType Type
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVariant_get_Type(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVariant_set_Type(this.NativePtr, value);
            }
        }

        public MfxStructVersion Version
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxVariant_get_Version(this.NativePtr);
                return new MfxStructVersion(ret, false);
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

            NativeMethods.oneapi_vpl_mfxVariant_delete(this.NativePtr);
        }

        #endregion

        public sealed class ValueDataHolder
        {
            
            #region Fields

            private readonly MfxVariant _Parent;

            #endregion

            #region Constructors

            internal ValueDataHolder(MfxVariant parent)
            {
                this._Parent = parent;
            }

            #endregion

            #region Properties
            
            public mfxU8 U8
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_U8(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_U8(this._Parent.NativePtr, value);
                }
            }

            public mfxI8 I8
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_I8(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_I8(this._Parent.NativePtr, value);
                }
            }

            public mfxU16 U16
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_U16(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_U16(this._Parent.NativePtr, value);
                }
            }

            public mfxI16 I16
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_I16(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_I16(this._Parent.NativePtr, value);
                }
            }

            public mfxU32 U32
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_U32(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_U32(this._Parent.NativePtr, value);
                }
            }

            public mfxI32 I32
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_I32(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_I32(this._Parent.NativePtr, value);
                }
            }

            public mfxU64 U64
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_U64(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_U64(this._Parent.NativePtr, value);
                }
            }

            public mfxI64 I64
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_I64(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_I64(this._Parent.NativePtr, value);
                }
            }

            public mfxF32 F32
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_F32(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_F32(this._Parent.NativePtr, value);
                }
            }

            public mfxF64 F64
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_F64(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_F64(this._Parent.NativePtr, value);
                }
            }

            public mfxHDL Ptr
            {
                get
                {
                    this._Parent.ThrowIfDisposed();
                    return NativeMethods.oneapi_vpl_mfxVariant_get_data_Ptr(this._Parent.NativePtr);
                }
                set
                {
                    this._Parent.ThrowIfDisposed();
                    NativeMethods.oneapi_vpl_mfxVariant_set_data_Ptr(this._Parent.NativePtr, value);
                }
            }

            #endregion

        }

    }

}