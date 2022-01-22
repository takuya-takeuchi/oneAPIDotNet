#ifndef _CPP_ONEAPI_VPL_MFXSTRUCTURES_H_
#define _CPP_ONEAPI_VPL_MFXSTRUCTURES_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

#pragma region mfxFrameData

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_A(mfxFrameData* data)
{
    return data->A;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_B(mfxFrameData* data)
{
    return data->B;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_Cb(mfxFrameData* data)
{
    return data->Cb;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_CbCr(mfxFrameData* data)
{
    return data->CbCr;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_Cr(mfxFrameData* data)
{
    return data->Cr;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_CrCb(mfxFrameData* data)
{
    return data->CrCb;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_G(mfxFrameData* data)
{
    return data->G;
}

DLLEXPORT mfxU16 const oneapi_vpl_mfxFrameData_get_Pitch(mfxFrameData* data)
{
    return data->Pitch;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_R(mfxFrameData* data)
{
    return data->R;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_U(mfxFrameData* data)
{
    return data->U;
}

DLLEXPORT mfxU16* const oneapi_vpl_mfxFrameData_get_U16(mfxFrameData* data)
{
    return data->U16;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_UV(mfxFrameData* data)
{
    return data->UV;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_V(mfxFrameData* data)
{
    return data->V;
}

DLLEXPORT mfxU16* const oneapi_vpl_mfxFrameData_get_V16(mfxFrameData* data)
{
    return data->V16;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_VU(mfxFrameData* data)
{
    return data->VU;
}

DLLEXPORT mfxU8* const oneapi_vpl_mfxFrameData_get_Y(mfxFrameData* data)
{
    return data->Y;
}

DLLEXPORT mfxU16* const oneapi_vpl_mfxFrameData_get_Y16(mfxFrameData* data)
{
    return data->Y16;
}

#pragma endregion mfxFrameData

#pragma region mfxFrameInfo

DLLEXPORT const mfxFrameInfo* oneapi_vpl_mfxFrameInfo_new()
{
    return new ::mfxFrameInfo();
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_delete(mfxFrameInfo* info)
{
    delete info;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_AspectRatioH(mfxFrameInfo* info, const mfxU16 value)
{
    info->AspectRatioH = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_AspectRatioH(mfxFrameInfo* info)
{
    return info->AspectRatioH;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_AspectRatioW(mfxFrameInfo* info, const mfxU16 value)
{
    info->AspectRatioW = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_AspectRatioW(mfxFrameInfo* info)
{
    return info->AspectRatioW;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_BitDepthChroma(mfxFrameInfo* info, const mfxU16 value)
{
    info->BitDepthChroma = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_BitDepthChroma(mfxFrameInfo* info)
{
    return info->BitDepthChroma;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_BitDepthLuma(mfxFrameInfo* info, const mfxU16 value)
{
    info->BitDepthLuma = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_BitDepthLuma(mfxFrameInfo* info)
{
    return info->BitDepthLuma;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_ChannelId(mfxFrameInfo* info, const mfxU16 value)
{
    info->ChannelId = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_ChannelId(mfxFrameInfo* info)
{
    return info->ChannelId;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_ChromaFormat(mfxFrameInfo* info, const mfxU16 value)
{
    info->ChromaFormat = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_ChromaFormat(mfxFrameInfo* info)
{
    return info->ChromaFormat;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_FourCC(mfxFrameInfo* info, const mfxU32 value)
{
    info->FourCC = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxFrameInfo_get_FourCC(mfxFrameInfo* info)
{
    return info->FourCC;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_FrameRateExtD(mfxFrameInfo* info, const mfxU32 value)
{
    info->FrameRateExtD = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxFrameInfo_get_FrameRateExtD(mfxFrameInfo* info)
{
    return info->FrameRateExtD;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_FrameRateExtN(mfxFrameInfo* info, const mfxU32 value)
{
    info->FrameRateExtN = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxFrameInfo_get_FrameRateExtN(mfxFrameInfo* info)
{
    return info->FrameRateExtN;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_Height(mfxFrameInfo* info)
{
    return info->Height;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_PicStruct(mfxFrameInfo* info, const mfxU16 value)
{
    info->PicStruct = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_PicStruct(mfxFrameInfo* info)
{
    return info->PicStruct;
}

DLLEXPORT void oneapi_vpl_mfxFrameInfo_set_Shift(mfxFrameInfo* info, const mfxU16 value)
{
    info->Shift = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_Shift(mfxFrameInfo* info)
{
    return info->Shift;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxFrameInfo_get_Width(mfxFrameInfo* info)
{
    return info->Width;
}

#pragma endregion mfxFrameInfo

#pragma region mfxFrameSurface1

DLLEXPORT const mfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Map(mfxFrameSurfaceInterface* interface,
                                                                  mfxFrameSurface1* surface,
                                                                  const mfxU32 flags)
{
    return interface->Map(surface, flags);
}

DLLEXPORT const mfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Release(mfxFrameSurfaceInterface* interface,
                                                                      mfxFrameSurface1* surface)
{
    return interface->Release(surface);
}

DLLEXPORT const mfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Synchronize(mfxFrameSurfaceInterface* interface,
                                                                          mfxFrameSurface1* surface,
                                                                          const mfxU32 wait)
{
    return interface->Synchronize(surface, wait);
}

DLLEXPORT const mfxStatus oneapi_vpl_mfxFrameSurfaceInterface_Unmap(mfxFrameSurfaceInterface* interface,
                                                                    mfxFrameSurface1* surface)
{
    return interface->Unmap(surface);
}

#pragma endregion mfxFrameSurface1

#pragma region mfxFrameSurface1

DLLEXPORT mfxFrameSurfaceInterface* const oneapi_vpl_mfxFrameSurface1_get_FrameInterface(mfxFrameSurface1* surface)
{
    return surface->FrameInterface;
}

DLLEXPORT mfxFrameData* const oneapi_vpl_mfxFrameSurface1_get_Data(mfxFrameSurface1* surface)
{
    return &(surface->Data);
}

DLLEXPORT mfxFrameInfo* const oneapi_vpl_mfxFrameSurface1_get_Info(mfxFrameSurface1* surface)
{
    return &(surface->Info);
}

#pragma endregion mfxFrameSurface1

#pragma region mfxInfoMFX

DLLEXPORT const mfxInfoMFX* oneapi_vpl_mfxInfoMFX_new()
{
    return new ::mfxInfoMFX();
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_delete(mfxInfoMFX* mfx)
{
    delete mfx;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_LowPower(mfxInfoMFX* mfx, const mfxU16 value)
{
    mfx->LowPower = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxInfoMFX_get_LowPower(mfxInfoMFX* mfx)
{
    return mfx->LowPower;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_BRCParamMultiplier(mfxInfoMFX* mfx, const mfxU16 value)
{
    mfx->BRCParamMultiplier = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxInfoMFX_get_BRCParamMultiplier(mfxInfoMFX* mfx)
{
    return mfx->BRCParamMultiplier;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_FrameInfo(mfxInfoMFX* mfx, const mfxFrameInfo value)
{
    mfx->FrameInfo = value;
}

DLLEXPORT mfxFrameInfo* const oneapi_vpl_mfxInfoMFX_get_FrameInfo(mfxInfoMFX* mfx)
{
    return &(mfx->FrameInfo);
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_CodecId(mfxInfoMFX* mfx, const mfxU32 value)
{
    mfx->CodecId = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxInfoMFX_get_CodecId(mfxInfoMFX* mfx)
{
    return mfx->CodecId;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_CodecProfile(mfxInfoMFX* mfx, const mfxU16 value)
{
    mfx->CodecProfile = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxInfoMFX_get_CodecProfile(mfxInfoMFX* mfx)
{
    return mfx->CodecProfile;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_CodecLevel(mfxInfoMFX* mfx, const mfxU16 value)
{
    mfx->CodecLevel = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxInfoMFX_get_CodecLevel(mfxInfoMFX* mfx)
{
    return mfx->CodecLevel;
}

DLLEXPORT void oneapi_vpl_mfxInfoMFX_set_NumThread(mfxInfoMFX* mfx, const mfxU16 value)
{
    mfx->NumThread = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxInfoMFX_get_NumThread(mfxInfoMFX* mfx)
{
    return mfx->NumThread;
}

#pragma endregion mfxVideoParam

#pragma region mfxVideoParam

DLLEXPORT const mfxVideoParam* oneapi_vpl_mfxVideoParam_new()
{
    return new ::mfxVideoParam();
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_delete(mfxVideoParam* param)
{
    delete param;
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_set_AllocId(mfxVideoParam* param, const mfxU32 value)
{
    param->AllocId = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxVideoParam_get_AllocId(mfxVideoParam* param)
{
    return param->AllocId;
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_set_AsyncDepth(mfxVideoParam* param, const mfxU16 value)
{
    param->AsyncDepth = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVideoParam_get_AsyncDepth(mfxVideoParam* param)
{
    return param->AsyncDepth;
}

DLLEXPORT mfxInfoMFX* const oneapi_vpl_mfxVideoParam_get_mfx(mfxVideoParam* param)
{
    return &(param->mfx);
}

DLLEXPORT mfxInfoVPP* const oneapi_vpl_mfxVideoParam_get_vpp(mfxVideoParam* param)
{
    return &(param->vpp);
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_set_Protected(mfxVideoParam* param, const mfxU16 value)
{
    param->Protected = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVideoParam_get_Protected(mfxVideoParam* param)
{
    return param->Protected;
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_set_IOPattern(mfxVideoParam* param, const mfxU16 value)
{
    param->IOPattern = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVideoParam_get_IOPattern(mfxVideoParam* param)
{
    return param->IOPattern;
}

DLLEXPORT void oneapi_vpl_mfxVideoParam_set_NumExtParam(mfxVideoParam* param, const mfxU16 value)
{
    param->NumExtParam = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVideoParam_get_NumExtParam(mfxVideoParam* param)
{
    return param->NumExtParam;
}

#pragma endregion mfxVideoParam

#endif // _CPP_ONEAPI_VPL_MFXVIDEO_H_