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

        #region MfxFrameInfo

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_A(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_B(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_Cb(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_CbCr(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_Cr(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_CrCb(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_G(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_R(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_U(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_U16(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_UV(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_V(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_V16(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_VU(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_Y(IntPtr data);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameData_get_Y16(IntPtr data);
        
        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameData_get_Pitch(IntPtr data);

        #endregion

        #region MfxFrameInfo

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameInfo_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_delete(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_AspectRatioH(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_AspectRatioH(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_AspectRatioW(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_AspectRatioW(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_BitDepthChroma(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_BitDepthChroma(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_BitDepthLuma(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_BitDepthLuma(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_ChannelId(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_ChannelId(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_ChromaFormat(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_ChromaFormat(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxFrameInfo_get_FourCC(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_FourCC(IntPtr info, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxFrameInfo_get_FrameRateExtD(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_FrameRateExtD(IntPtr info, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxFrameInfo_get_FrameRateExtN(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_FrameRateExtN(IntPtr info, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_Height(IntPtr info);


        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_PicStruct(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_PicStruct(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_Shift(IntPtr info);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxFrameInfo_set_Shift(IntPtr info, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxFrameInfo_get_Width(IntPtr info);

        #endregion

        #region MfxFrameSurfaceInterface

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Map(IntPtr @interface, IntPtr surface, MfxMemoryFlags flags);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Release(IntPtr @interface, IntPtr surface);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Synchronize(IntPtr @interface, IntPtr surface, mfxU32 wait);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern MfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Unmap(IntPtr @interface, IntPtr surface);

        #endregion

        #region MfxFrameSurface1

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameSurface1_get_FrameInterface(IntPtr surface);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameSurface1_get_Data(IntPtr surface);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxFrameSurface1_get_Info(IntPtr surface);

        #endregion

        #region MfxInfoMFX

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxInfoMFX_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_delete(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxInfoMFX_get_LowPower(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_LowPower(IntPtr mfx, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxInfoMFX_get_BRCParamMultiplier(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_BRCParamMultiplier(IntPtr mfx, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxInfoMFX_get_FrameInfo(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxInfoMFX_get_CodecId(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_CodecId(IntPtr mfx, mfxU32 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxInfoMFX_get_CodecProfile(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_CodecProfile(IntPtr mfx, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxInfoMFX_get_CodecLevel(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_CodecLevel(IntPtr mfx, mfxU16 value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxInfoMFX_get_NumThread(IntPtr mfx);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxInfoMFX_set_NumThread(IntPtr mfx, mfxU16 value);

        #endregion

        #region MfxVideoParam

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVideoParam_new();

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_delete(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU32 oneapi_vpl_mfxVideoParam_get_AllocId(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_set_AllocId(IntPtr param, mfxU32  value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVideoParam_get_AsyncDepth(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_set_AsyncDepth(IntPtr param, mfxU16  value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVideoParam_get_mfx(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr oneapi_vpl_mfxVideoParam_get_vpp(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVideoParam_get_Protected(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_set_Protected(IntPtr param, mfxU16  value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVideoParam_get_IOPattern(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_set_IOPattern(IntPtr param, mfxU16  value);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern mfxU16 oneapi_vpl_mfxVideoParam_get_NumExtParam(IntPtr param);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void oneapi_vpl_mfxVideoParam_set_NumExtParam(IntPtr param, mfxU16  value);

        #endregion

        #endregion

    }

}