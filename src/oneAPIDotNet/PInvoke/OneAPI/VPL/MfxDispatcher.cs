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
        public static extern IntPtr oneapi_vpl_MFXLoad();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_MFXUnload(IntPtr loader);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_MFXCreateConfig(IntPtr loader);
                                                      
        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXCreateSession(IntPtr loader, uint32_t i, out IntPtr session);
                                                      
        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXDispReleaseImplDescription(IntPtr loader, mfxHDL hdl);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXEnumImplementations(IntPtr loader,
                                                                         uint32_t i,
                                                                         MfxImplCapsDeliveryFormat format,
                                                                         out IntPtr idesc);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXSetConfigFilterProperty(IntPtr config, byte[] name, uint32_t name_len, IntPtr variant);

        #endregion

    }

}