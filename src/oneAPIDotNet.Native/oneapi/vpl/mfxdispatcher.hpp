#ifndef _CPP_ONEAPI_VPL_MFXDISPATCHER_H_
#define _CPP_ONEAPI_VPL_MFXDISPATCHER_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

DLLEXPORT const mfxLoader oneapi_vpl_MFXLoad()
{
    return ::MFXLoad();
}

DLLEXPORT void oneapi_vpl_MFXUnload(mfxLoader loader)
{
    ::MFXUnload(loader);
}

DLLEXPORT const mfxConfig oneapi_vpl_MFXCreateConfig(mfxLoader loader)
{
    return ::MFXCreateConfig(loader);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXCreateSession(mfxLoader loader,
                                                      const mfxU32 i,
                                                      _mfxSession** session)
{
    return ::MFXCreateSession(loader, i, session);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXDispReleaseImplDescription(mfxLoader loader,
                                                                   mfxHDL hdl)
{
    return ::MFXDispReleaseImplDescription(loader, hdl);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXEnumImplementations(mfxLoader loader,
                                                            const mfxU32 i,
                                                            const mfxImplCapsDeliveryFormat format,
                                                            mfxHDL* const idesc)
{
    return ::MFXEnumImplementations(loader, i, format, idesc);
}

DLLEXPORT const mfxStatus oneapi_vpl_MFXSetConfigFilterProperty(mfxConfig config,
                                                                const char* name,
                                                                const uint32_t name_len,
                                                                mfxVariant* variant)
{
    auto n = std::string(name, name_len);
    // auto& v = *variant;
    mfxVariant v;
    std::memcpy(&v, variant, sizeof(mfxVariant));
    return ::MFXSetConfigFilterProperty(config, (mfxU8*)n.c_str(), v);
}

#endif // _CPP_ONEAPI_VPL_MFXDISPATCHER_H_