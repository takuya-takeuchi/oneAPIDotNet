#ifndef _CPP_ONEAPI_VPL_MFXSESSION_H_
#define _CPP_ONEAPI_VPL_MFXSESSION_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

DLLEXPORT const mfxStatus oneapi_vpl_MFXClose(mfxSession session)
{
    return ::MFXClose(session);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXInit(const mfxIMPL impl,
                                             mfxVersion* version,
                                             _mfxSession** session)
{
    return ::MFXInit(impl, version, session);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXQueryIMPL(mfxSession session, mfxIMPL* impl)
{
    return ::MFXQueryIMPL(session, impl);
}

// DLLEXPORT const mfxStatus oneapi_vpl_MFXInitialize(mfxInitializationParam* par,
//                                                    _mfxSession** session)
// {
//     auto& p = *par;
//     return ::MFXInitialize(p, session);
// }

#endif // _CPP_ONEAPI_VPL_MFXSESSION_H_