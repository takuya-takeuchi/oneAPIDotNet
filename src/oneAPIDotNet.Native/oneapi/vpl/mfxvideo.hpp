#ifndef _CPP_ONEAPI_VPL_MFXVIDEO_H_
#define _CPP_ONEAPI_VPL_MFXVIDEO_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

DLLEXPORT const mfxStatus oneapi_vpl_MFXVideoDECODE_Init(mfxSession session,
                                                         mfxVideoParam* const par)
{
    return ::MFXVideoDECODE_Init(session, par);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXVideoDECODE_Close(mfxSession session)
{
    return ::MFXVideoDECODE_Close(session);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXVideoDECODE_DecodeFrameAsync(mfxSession session,
                                                                     mfxBitstream* const bs,
                                                                     mfxFrameSurface1* const surface_work,
                                                                     mfxFrameSurface1** surface_out,
                                                                     mfxSyncPoint* const syncp)
{
    return ::MFXVideoDECODE_DecodeFrameAsync(session, bs, surface_work, surface_out, syncp);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXVideoDECODE_DecodeHeader(mfxSession session,
                                                                 mfxBitstream* const bs,
                                                                 mfxVideoParam* const par)
{
    return ::MFXVideoDECODE_DecodeHeader(session, bs, par);
}

#endif // _CPP_ONEAPI_VPL_MFXVIDEO_H_