using System;

namespace OneAPIDotNet.VPL
{

    [Flags]
    public enum MfxImplType
    {

        /// <summary>
        /// Pure Software Implementation.
        /// </summary>
        Software = 0x0001,

        /// <summary>
        /// Hardware Accelerated Implementation.
        /// </summary>
        Hardware = 0x0002

    }

}