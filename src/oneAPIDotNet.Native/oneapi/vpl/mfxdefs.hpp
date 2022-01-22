#ifndef _CPP_ONEAPI_VPL_MFXDEFS_H_
#define _CPP_ONEAPI_VPL_MFXDEFS_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

DLLEXPORT const uint32_t oneapi_vpl_get_MFX_VERSION_MAJOR()
{
    return MFX_VERSION_MAJOR;
}

DLLEXPORT const uint32_t oneapi_vpl_get_MFX_VERSION_MINOR()
{
    return MFX_VERSION_MINOR;
}

DLLEXPORT const uint32_t oneapi_vpl_get_MFX_VERSION()
{
    return MFX_VERSION;
}

DLLEXPORT const uint32_t oneapi_vpl_get_MFX_LEGACY_VERSION()
{
    return MFX_LEGACY_VERSION;
}

#pragma region mfxVariant

DLLEXPORT const mfxVariant* oneapi_vpl_mfxVariant_new()
{
    // return new ::mfxVariant();
    auto variant = new ::mfxVariant();
    std::memset(variant, 0, sizeof(::mfxVariant));
    return variant;
}

DLLEXPORT void oneapi_vpl_mfxVariant_delete(mfxVariant* variant)
{
    delete variant;
}

DLLEXPORT const mfxVariantType oneapi_vpl_mfxVariant_get_Type(mfxVariant* variant)
{
    return variant->Type;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_Type(mfxVariant* variant, const mfxVariantType type)
{
    variant->Type = type;
}

DLLEXPORT const mfxU8   oneapi_vpl_mfxVariant_get_data_U8(mfxVariant* variant)
{
    return variant->Data.U8;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_U8(mfxVariant* variant, const mfxU8 value)
{
    variant->Data.U8 = value;
}

DLLEXPORT const mfxI8   oneapi_vpl_mfxVariant_get_data_I8(mfxVariant* variant)
{
    return variant->Data.I8;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_I8(mfxVariant* variant, const mfxI8 value)
{
    variant->Data.I8 = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVariant_get_data_U16(mfxVariant* variant)
{
    return variant->Data.U16;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_U16(mfxVariant* variant, const mfxU16 value)
{
    variant->Data.U16 = value;
}

DLLEXPORT const mfxI16 oneapi_vpl_mfxVariant_get_data_I16(mfxVariant* variant)
{
    return variant->Data.I16;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_I16(mfxVariant* variant, const mfxI16 value)
{
    variant->Data.I16 = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxVariant_get_data_U32(mfxVariant* variant)
{
    return variant->Data.U32;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_U32(mfxVariant* variant, const mfxU32 value)
{
    variant->Data.U32 = value;
}

DLLEXPORT const mfxI32 oneapi_vpl_mfxVariant_get_data_I32(mfxVariant* variant)
{
    return variant->Data.I32;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_I32(mfxVariant* variant, const mfxI32 value)
{
    variant->Data.I32 = value;
}

DLLEXPORT const mfxU64 oneapi_vpl_mfxVariant_get_data_U64(mfxVariant* variant)
{
    return variant->Data.U64;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_U64(mfxVariant* variant, const mfxU64 value)
{
    variant->Data.U64 = value;
}

DLLEXPORT const mfxI64 oneapi_vpl_mfxVariant_get_data_I64(mfxVariant* variant)
{
    return variant->Data.I64;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_I64(mfxVariant* variant, const mfxI64 value)
{
    variant->Data.I64 = value;
}

DLLEXPORT const mfxF32 oneapi_vpl_mfxVariant_get_data_F32(mfxVariant* variant)
{
    return variant->Data.F32;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_F32(mfxVariant* variant, const mfxF32 value)
{
    variant->Data.F32 = value;
}

DLLEXPORT const mfxF64 oneapi_vpl_mfxVariant_get_data_F64(mfxVariant* variant)
{
    return variant->Data.F64;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_F64(mfxVariant* variant, const mfxF64 value)
{
    variant->Data.F64 = value;
}

DLLEXPORT const mfxHDL oneapi_vpl_mfxVariant_get_data_Ptr(mfxVariant* variant)
{
    return variant->Data.Ptr;
}

DLLEXPORT void oneapi_vpl_mfxVariant_set_data_Ptr(mfxVariant* variant, const mfxHDL value)
{
    variant->Data.Ptr = value;
}

DLLEXPORT mfxStructVersion* const oneapi_vpl_mfxVariant_get_Version(mfxVariant* variant)
{
    return &(variant->Version);
}

// DLLEXPORT void oneapi_vpl_mfxVariant_get_Version(mfxVariant* variant, mfxStructVersion* const version)
// {
//     memcpy(version, &(variant->Version), sizeof(mfxStructVersion));
// }

DLLEXPORT void oneapi_vpl_mfxVariant_set_Version(mfxVariant* variant, mfxStructVersion* const version)
{
    memcpy(&(variant->Version), version, sizeof(mfxStructVersion));
}

#pragma endregion mfxVariant

#pragma endregion mfxVersion

#endif // _CPP_ONEAPI_VPL_MFXDEFS_H_