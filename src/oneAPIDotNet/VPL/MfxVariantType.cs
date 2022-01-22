namespace OneAPIDotNet.VPL
{

    public enum MfxVariantType
    {

        /// <summary>
        /// Undefined type.
        /// </summary>
        Unset = 0,

        /// <summary>
        /// 8-bit unsigned integer.
        /// </summary>
        U8 = 1,

        /// <summary>
        /// 8-bit signed integer.
        /// </summary>
        I8,

        /// <summary>
        /// 16-bit unsigned integer.
        /// </summary>
        U16,

        /// <summary>
        /// 16-bit signed integer.
        /// </summary>
        I16,

        /// <summary>
        /// 32-bit unsigned integer.
        /// </summary>
        U32,

        /// <summary>
        /// 32-bit signed integer.
        /// </summary>
        I32,

        /// <summary>
        /// 64-bit unsigned integer.
        /// </summary>
        U64,

        /// <summary>
        /// 64-bit signed integer.
        /// </summary>
        I64,

        /// <summary>
        /// 32-bit single precision floating point.
        /// </summary>
        F32,

        /// <summary>
        /// 64-bit double precision floating point.
        /// </summary>
        F64,

        /// <summary>
        /// Generic type pointer.
        /// </summary>
        Pointer

    }

}