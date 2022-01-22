#ifndef _CPP_ONEAPI_VPL_MFXCOMMON_H_
#define _CPP_ONEAPI_VPL_MFXCOMMON_H_

#include "../export.hpp"
#include "../shared.hpp"

#include "vpl.h"

#pragma region mfxBitstream

DLLEXPORT const mfxBitstream* oneapi_vpl_mfxBitstream_new()
{
    return new ::mfxBitstream();
}

DLLEXPORT void oneapi_vpl_mfxBitstream_delete(mfxBitstream* stream)
{
    delete stream;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxBitstream_get_CodecId(mfxBitstream* stream)
{
    return stream->CodecId;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_CodecId(mfxBitstream* stream, const mfxU32 value)
{
    stream->CodecId = value;
}

DLLEXPORT const mfxI64 oneapi_vpl_mfxBitstream_get_DecodeTimeStamp(mfxBitstream* stream)
{
    return stream->DecodeTimeStamp;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_DecodeTimeStamp(mfxBitstream* stream, const mfxI64 value)
{
    stream->DecodeTimeStamp = value;
}

DLLEXPORT const mfxU64 oneapi_vpl_mfxBitstream_get_TimeStamp(mfxBitstream* stream)
{
    return stream->TimeStamp;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_TimeStamp(mfxBitstream* stream, const mfxU64 value)
{
    stream->TimeStamp = value;
}

DLLEXPORT const mfxU8* oneapi_vpl_mfxBitstream_get_Data(mfxBitstream* stream)
{
    return stream->Data;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_Data(mfxBitstream* stream, mfxU8* const value)
{
    stream->Data = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxBitstream_get_DataOffset(mfxBitstream* stream)
{
    return stream->DataOffset;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_DataOffset(mfxBitstream* stream, const mfxU32 value)
{
    stream->DataOffset = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxBitstream_get_DataLength(mfxBitstream* stream)
{
    return stream->DataLength;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_DataLength(mfxBitstream* stream, const mfxU32 value)
{
    stream->DataLength = value;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxBitstream_get_MaxLength(mfxBitstream* stream)
{
    return stream->MaxLength;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_MaxLength(mfxBitstream* stream, const mfxU32 value)
{
    stream->MaxLength = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxBitstream_get_PicStruct(mfxBitstream* stream)
{
    return stream->PicStruct;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_PicStruct(mfxBitstream* stream, const mfxU16 value)
{
    stream->PicStruct = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxBitstream_get_FrameType(mfxBitstream* stream)
{
    return stream->FrameType;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_FrameType(mfxBitstream* stream, const mfxU16 value)
{
    stream->FrameType = value;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxBitstream_get_DataFlag(mfxBitstream* stream)
{
    return stream->DataFlag;
}

DLLEXPORT void oneapi_vpl_mfxBitstream_set_DataFlag(mfxBitstream* stream, const mfxU16 value)
{
    stream->DataFlag = value;
}

#pragma endregion

#pragma region mfxInitializationParam

DLLEXPORT const mfxInitializationParam* oneapi_vpl_mfxInitializationParam_new()
{
    return new ::mfxInitializationParam();
}

DLLEXPORT void oneapi_vpl_mfxInitializationParam_delete(mfxInitializationParam* param)
{
    delete param;
}

#pragma endregion mfxInitializationParam

#pragma region mfxImplDescription

DLLEXPORT const mfxImplDescription* oneapi_vpl_mfxImplDescription_new()
{
    return new ::mfxImplDescription();
}

DLLEXPORT void oneapi_vpl_mfxImplDescription_delete(mfxImplDescription* description)
{
    delete description;
}

DLLEXPORT const mfxStructVersion* oneapi_vpl_mfxImplDescription_get_Version(mfxImplDescription* description)
{
    return &(description->Version);
}

DLLEXPORT const mfxImplType oneapi_vpl_mfxImplDescription_get_Impl(mfxImplDescription* description)
{
    return description->Impl;
}

DLLEXPORT const mfxAccelerationMode oneapi_vpl_mfxImplDescription_get_AccelerationMode(mfxImplDescription* description)
{
    return description->AccelerationMode;
}

DLLEXPORT mfxVersion* const oneapi_vpl_mfxImplDescription_get_ApiVersion(mfxImplDescription* description)
{
    return &(description->ApiVersion);
}

#pragma endregion mfxImplDescription

#pragma region mfxStructVersion

DLLEXPORT const mfxStructVersion* oneapi_vpl_mfxStructVersion_new()
{
    return new ::mfxStructVersion();
}

DLLEXPORT void oneapi_vpl_mfxStructVersion_delete(mfxStructVersion* version)
{
    delete version;
}

DLLEXPORT const mfxU8 oneapi_vpl_mfxStructVersion_get_Major(mfxStructVersion* version)
{
    return version->Major;
}

DLLEXPORT void oneapi_vpl_mfxStructVersion_set_Major(mfxStructVersion* version, const mfxU8 major)
{
    version->Major = major;
}

DLLEXPORT const mfxU8 oneapi_vpl_mfxStructVersion_get_Minor(mfxStructVersion* version)
{
    return version->Minor;
}

DLLEXPORT void oneapi_vpl_mfxStructVersion_set_Minor(mfxStructVersion* version, const mfxU8 minor)
{
    version->Minor = minor;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxStructVersion_get_Version(mfxStructVersion* version)
{
    return version->Version;
}

DLLEXPORT void oneapi_vpl_mfxStructVersion_set_Version(mfxStructVersion* version, const mfxU16 versionNumber)
{
    version->Version = versionNumber;
}

#pragma endregion mfxStructVersion

#pragma region mfxVersion

DLLEXPORT const mfxVersion* oneapi_vpl_mfxVersion_new()
{
    return new ::mfxVersion();
}

DLLEXPORT void oneapi_vpl_mfxVersion_delete(mfxVersion* version)
{
    delete version;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVersion_get_Major(mfxVersion* version)
{
    return version->Major;
}

DLLEXPORT void oneapi_vpl_mfxVersion_set_Major(mfxVersion* version, const mfxU16 major)
{
    version->Major = major;
}

DLLEXPORT const mfxU16 oneapi_vpl_mfxVersion_get_Minor(mfxVersion* version)
{
    return version->Minor;
}

DLLEXPORT void oneapi_vpl_mfxVersion_set_Minor(mfxVersion* version, const mfxU16 minor)
{
    version->Minor = minor;
}

DLLEXPORT const mfxU32 oneapi_vpl_mfxVersion_get_Version(mfxVersion* version)
{
    return version->Version;
}

DLLEXPORT void oneapi_vpl_mfxVersion_set_Version(mfxVersion* version, const mfxU32 versionNumber)
{
    version->Version = versionNumber;
}

#pragma endregion mfxVersion

#endif // _CPP_ONEAPI_VPL_MFXCOMMON_H_