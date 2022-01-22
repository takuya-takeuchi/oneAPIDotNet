namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// This enum itemizes hardware acceleration stack to use.
    /// </summary>
    public enum MfxAccelerationMode
    {

        /// <summary>
        /// Hardware acceleration is not applicable.
        /// </summary>
        NotApplicable = 0,

        /// <summary>
        /// Hardware acceleration goes through the Microsoft* Direct3D9* infrastructure.
        /// </summary>
        ViaDirect3D9 = 0x0200,

        /// <summary>
        /// Hardware acceleration goes through the Microsoft* Direct3D11* infrastructure.
        /// </summary>
        ViaDirect3D11 = 0x0300,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure.
        /// </summary>
        ViaVAAPI = 0x0400,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure with DRM RENDER MODE as default acceleration access point.
        /// </summary>
        ViaVAAPIDRMRenderMode = ViaVAAPI,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure with DRM MODESET as  default acceleration access point.
        /// </summary>
        ViaVAAPIDRMModeSet = 0x0401,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure with OpenGL Extension to the X Window System as default acceleration access point.
        /// </summary>
        ViaVAAPIGLX = 0x0402,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure with X11 as default acceleration access point.
        /// </summary>
        ViaVAAPIX11 = 0x0403,

        /// <summary>
        /// Hardware acceleration goes through the Linux* VA-API infrastructure with Wayland as default acceleration access point.
        /// </summary>
        ViaVAAPIWayland = 0x0404,

        /// <summary>
        /// Hardware acceleration goes through the HDDL* Unite*.
        /// </summary>
        ViaHDDLUnite = 0x0500

    }

}