namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// The IOPattern enumerator itemizes memory access patterns for API functions.
    /// </summary>
    public enum MfxIOPattern
    {

        /// <summary>
        /// Input to functions is a video memory surface.
        /// </summary>
        InVideoMemory   = 0x01,

        /// <summary>
        /// Input to functions is a linear buffer directly in system memory or in system memory through an external allocator.
        /// </summary>
        InSystemMemory  = 0x02,

        /// <summary>
        /// Output to functions is a video memory surface.
        /// </summary>
        OutVideoMemory  = 0x10,

        /// <summary>
        /// Output to functions is a linear buffer directly in system memory or in system memory through an external allocator.
        /// </summary>
        OutSystemMemory = 0x20

    }

}