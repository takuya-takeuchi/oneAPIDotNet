namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Enumerator specifies memory access mode.
    /// </summary>
    public enum MfxMemoryFlags
    {

        /// <summary>
        /// The surface is mapped for reading.
        /// </summary>
        Read  = 0x1,
    
        /// <summary>
        /// The surface is mapped for writing.
        /// </summary>
        Write = 0x2,
    
        /// <summary>
        /// The surface is mapped for reading and writing.
        /// </summary>
        ReadWrite = Read | Write,
    
        /// <summary>
        /// The mapping would be done immediately without any implicit synchronizations.
        /// </summary>
        NoWait = 0x10

    }

}