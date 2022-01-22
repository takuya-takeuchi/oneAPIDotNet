using System;

namespace OneAPIDotNet.VPL
{

    [Flags]
    public enum MfxImpl
    {

        /// <summary>
        /// Auto Selection/In or Not Supported/Out.
        /// </summary>
        Auto = 0x0000,

        /// <summary>
        /// Pure software implementation.
        /// </summary>
        Software = 0x0001,

        /// <summary>
        /// Hardware accelerated implementation (default device).
        /// </summary>
        Hardware = 0x0002,

        /// <summary>
        /// Auto selection of any hardware/software implementation.
        /// </summary>
        AutoAny = 0x0003,

        /// <summary>
        /// Auto selection of any hardware implementation.
        /// </summary>
        HardwareAny = 0x0004,

        /// <summary>
        /// Hardware accelerated implementation (2nd device).
        /// </summary>
        Hardware2 = 0x0005,

        /// <summary>
        /// Hardware accelerated implementation (3rd device).
        /// </summary>
        Hardware3 = 0x0006,

        /// <summary>
        /// Hardware accelerated implementation (4th device).
        /// </summary>
        Hardware4 = 0x0007,

        /// <summary>
        /// This value cannot be used for session initialization. It may be returned by the MFXQueryIMPL function to show that the session has been initialized in run-time mode.
        /// </summary>
        Runtime = 0x0008,

        /// <summary>
        /// Hardware acceleration can go through any supported OS infrastructure. This is the default value. The default value is used by the legacy Intel(r) Media SDK if none of the VIA_xxx flags are specified by the application.
        /// </summary>
        ViaANY = 0x0100,

        /// <summary>
        /// Hardware acceleration goes through the Microsoft* Direct3D* 9 infrastructure.
        /// </summary>
        ViaD3D9 = 0x0200,

        /// <summary>
        /// Hardware acceleration goes through the Microsoft* Direct3D* 11 infrastructure.
        /// </summary>
        ViaD3D11 = 0x0300,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure.
        /// </summary>
        ViaVAAPI = 0x0400,

        /// <summary>
        /// Hardware acceleration goes through the HDDL* Unite*.
        /// </summary>
        ViaHDDLUnite = 0x0500,

        /// <summary>
        /// One of the MFXQueryIMPL returns.
        /// </summary>
        Unsupported = 0x0000  

    }

}