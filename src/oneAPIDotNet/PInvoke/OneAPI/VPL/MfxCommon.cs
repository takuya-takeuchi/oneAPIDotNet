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

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet
{

    internal sealed partial class NativeMethods
    {

        #region Functions

        #region MfxBitstream

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxBitstream_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_delete(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32  oneapi_vpl_mfxBitstream_get_CodecId(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_CodecId(IntPtr stream, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxI64  oneapi_vpl_mfxBitstream_get_DecodeTimeStamp(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_DecodeTimeStamp(IntPtr stream, mfxI64 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU64  oneapi_vpl_mfxBitstream_get_TimeStamp(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_TimeStamp(IntPtr stream, mfxU64 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxBitstream_get_Data(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_Data(IntPtr stream, IntPtr value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32  oneapi_vpl_mfxBitstream_get_DataOffset(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_DataOffset(IntPtr stream, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32  oneapi_vpl_mfxBitstream_get_DataLength(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_DataLength(IntPtr stream, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32  oneapi_vpl_mfxBitstream_get_MaxLength(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_MaxLength(IntPtr stream, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16  oneapi_vpl_mfxBitstream_get_PicStruct(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_PicStruct(IntPtr stream, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16  oneapi_vpl_mfxBitstream_get_FrameType(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_FrameType(IntPtr stream, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16  oneapi_vpl_mfxBitstream_get_DataFlag(IntPtr stream);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxBitstream_set_DataFlag(IntPtr stream, mfxU16 value);
        
        #endregion

        #region MfxInitializationParam

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxInitializationParam_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInitializationParam_delete(IntPtr param);

        #endregion

        #region MfxImplDescription

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxImplDescription_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxImplDescription_delete(IntPtr description);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxImplDescription_get_Version(IntPtr description);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern OneAPIDotNet.VPL.MfxImplType oneapi_vpl_mfxImplDescription_get_Impl(IntPtr description);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern OneAPIDotNet.VPL.MfxAccelerationMode oneapi_vpl_mfxImplDescription_get_AccelerationMode(IntPtr description);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxImplDescription_get_ApiVersion(IntPtr description);

        #endregion

        #region MfxStructVersion

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxStructVersion_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxStructVersion_delete(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU8 oneapi_vpl_mfxStructVersion_get_Major(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxStructVersion_set_Major(IntPtr version, mfxU8 major);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU8 oneapi_vpl_mfxStructVersion_get_Minor(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxStructVersion_set_Minor(IntPtr version, mfxU8 minor);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxStructVersion_get_Version(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxStructVersion_set_Version(IntPtr version, mfxU16 versionNumber);

        #endregion

        #region MfxVersion

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVersion_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVersion_delete(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVersion_get_Major(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVersion_set_Major(IntPtr version, mfxU16 major);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVersion_get_Minor(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVersion_set_Minor(IntPtr version, mfxU16 minor);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxVersion_get_Version(IntPtr version);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVersion_set_Version(IntPtr version, mfxU32 versionNumber);

        #endregion

        #endregion

    }

}