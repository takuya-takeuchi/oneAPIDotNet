using System;
using System.Runtime.InteropServices;
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using int64_t = System.Int64;
using int8_t = System.SByte;
using int16_t = System.Int16;
using int32_t = System.Int32;

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

using OneAPIDotNet.VPL;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet
{

    internal sealed partial class NativeMethods
    {

        #region Functions

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint32_t oneapi_vpl_get_MFX_VERSION_MAJOR();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint32_t oneapi_vpl_get_MFX_VERSION_MINOR();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint32_t oneapi_vpl_get_MFX_VERSION();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern uint32_t oneapi_vpl_get_MFX_LEGACY_VERSION();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVariant_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_delete(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxVariantType oneapi_vpl_mfxVariant_get_Type(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_Type(IntPtr variant, MfxVariantType type);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU8   oneapi_vpl_mfxVariant_get_data_U8(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_U8(IntPtr variant, mfxU8 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxI8   oneapi_vpl_mfxVariant_get_data_I8(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_I8(IntPtr variant, mfxI8 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVariant_get_data_U16(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_U16(IntPtr variant, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxI16 oneapi_vpl_mfxVariant_get_data_I16(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_I16(IntPtr variant, mfxI16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxVariant_get_data_U32(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_U32(IntPtr variant, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxI32 oneapi_vpl_mfxVariant_get_data_I32(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_I32(IntPtr variant, mfxI32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU64 oneapi_vpl_mfxVariant_get_data_U64(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_U64(IntPtr variant, mfxU64 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxI64 oneapi_vpl_mfxVariant_get_data_I64(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_I64(IntPtr variant, mfxI64 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxF32 oneapi_vpl_mfxVariant_get_data_F32(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_F32(IntPtr variant, mfxF32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxF64 oneapi_vpl_mfxVariant_get_data_F64(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_F64(IntPtr variant, mfxF64 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxHDL oneapi_vpl_mfxVariant_get_data_Ptr(IntPtr variant);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_data_Ptr(IntPtr variant, mfxHDL value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVariant_get_Version(IntPtr variant);

        // [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        // public static extern void oneapi_vpl_mfxVariant_get_Version(IntPtr variant, IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVariant_set_Version(IntPtr variant, IntPtr version);

        #endregion

    }

}