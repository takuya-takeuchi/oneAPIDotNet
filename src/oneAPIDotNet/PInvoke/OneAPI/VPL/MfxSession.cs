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
using mfxU16 = System.UInt16;
using mfxU32 = System.UInt32;
using mfxI32 = System.Int32;
using mfxIMPL = System.Int32;

using OneAPIDotNet.VPL;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet
{

    internal sealed partial class NativeMethods
    {

        #region Functions

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXClose(IntPtr session);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXInit(mfxIMPL impl, IntPtr version, out IntPtr session);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_MFXQueryIMPL(IntPtr session, out mfxIMPL impl);

        #endregion

    }

}