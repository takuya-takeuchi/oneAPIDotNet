namespace OneAPIDotNet.VPL
{

    public enum MfxFourCC
    {

        /// <summary>
        /// NV12 color planes. Native format for 4:2:0/8b Gen hardware implementation. */
        /// </summary>
        NV12 = ((((int)'N'))+(((int)'V')<<8)+(((int)'1')<<16)+(((int)'2')<<24)),

        /// <summary>
        /// YV12 color planes. */
        /// </summary>
        YV12 = ((((int)'Y'))+(((int)'V')<<8)+(((int)'1')<<16)+(((int)'2')<<24)),

        /// <summary>
        /// 4:2:2 color format with similar to NV12 layout. */
        /// </summary>
        NV16 = ((((int)'N'))+(((int)'V')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// YUY2 color planes. */
        /// </summary>
        YUY2 = ((((int)'Y'))+(((int)'U')<<8)+(((int)'Y')<<16)+(((int)'2')<<24)),

        /// <summary>
        /// 2 bytes per pixel, uint16 in little-endian format, where 0-4 bits are blue, bits 5-10 are green and bits 11-15 are red. */
        /// </summary>
        RGB565 = ((((int)'R'))+(((int)'G')<<8)+(((int)'B')<<16)+(((int)'2')<<24)),

	    RGBP = ((((int)'R'))+(((int)'G')<<8)+(((int)'B')<<16)+(((int)'P')<<24)),

        /// <summary>
        /// Deprecated
        /// </summary>
	    GB3 = ((((int)'R'))+(((int)'G')<<8)+(((int)'B')<<16)+(((int)'3')<<24)),

        /// <summary>
        /// RGB4 (RGB32) color planes. BGRA is the order, ‘B’ is 8 MSBs, then 8 bits for ‘G’ channel, then ‘R’ and ‘A’ channels. */
        /// </summary>
        RGB4 = ((((int)'R'))+(((int)'G')<<8)+(((int)'B')<<16)+(((int)'4')<<24)),

	    P8Texture = ((((int)'P'))+(((int)'8')<<8)+(((int)'M')<<16)+(((int)'B')<<24)),

        /// <summary>
        /// P010 color format. This is 10 bit per sample format with similar to NV12 layout. This format should be mapped to DXGI_FORMAT_P010. */
        /// </summary>
        P010 = ((((int)'P'))+(((int)'0')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// P016 color format. This is 16 bit per sample format with similar to NV12 layout. This format should be mapped to DXGI_FORMAT_P016. */
        /// </summary>
        P016 = ((((int)'P'))+(((int)'0')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// 10 bit per sample 4:2:2 color format with similar to NV12 layout. */
        /// </summary>
        P210 = ((((int)'P'))+(((int)'2')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// RGBA color format. It is similar to MFX_FOURCC_RGB4 but with different order of channels. ‘R’ is 8 MSBs, then 8 bits for ‘G’ channel, then ‘B’ and ‘A’ channels. */
        /// </summary>
        BGR4 = ((((int)'B'))+(((int)'G')<<8)+(((int)'R')<<16)+(((int)'4')<<24)),

        /// <summary>
        /// 10 bits ARGB color format packed in 32 bits. ‘A’ channel is two MSBs, then ‘R’, then ‘G’ and then ‘B’ channels. This format should be mapped to DXGI_FORMAT_R10G10B10A2_UNORM or D3DFMT_A2R10G10B10. */
        /// </summary>
        A2RGB10 = ((((int)'R'))+(((int)'G')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// 10 bits ARGB color format packed in 64 bits. ‘A’ channel is 16 MSBs, then ‘R’, then ‘G’ and then ‘B’ channels. This format should be mapped to DXGI_FORMAT_R16G16B16A16_UINT or D3DFMT_A16B16G16R16 formats. */
        /// </summary>
        ARGB16 = ((((int)'R'))+(((int)'G')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// 10 bits ABGR color format packed in 64 bits. ‘A’ channel is 16 MSBs, then ‘B’, then ‘G’ and then ‘R’ channels. This format should be mapped to DXGI_FORMAT_R16G16B16A16_UINT or D3DFMT_A16B16G16R16 formats. */
        /// </summary>
        ABGR16 = ((((int)'B'))+(((int)'G')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// 16 bits single channel color format. This format should be mapped to DXGI_FORMAT_R16_TYPELESS or D3DFMT_R16F. */
        /// </summary>
        R16 = ((((int)'R'))+(((int)'1')<<8)+(((int)'6')<<16)+(((int)'U')<<24)),

        /// <summary>
        /// YUV 4:4:4, AYUV color format. This format should be mapped to DXGI_FORMAT_AYUV. */
        /// </summary>
        AYUV = ((((int)'A'))+(((int)'Y')<<8)+(((int)'U')<<16)+(((int)'V')<<24)),

        /// <summary>
        /// RGB4 stored in AYUV surface. This format should be mapped to DXGI_FORMAT_AYUV. */
        /// </summary>
        AYUV_RGB4 = ((((int)'A'))+(((int)'V')<<8)+(((int)'U')<<16)+(((int)'Y')<<24)),

        /// <summary>
        /// UYVY color planes. Same as YUY2 except the byte order is reversed. */
        /// </summary>
        UYVY = ((((int)'U'))+(((int)'Y')<<8)+(((int)'V')<<16)+(((int)'Y')<<24)),

        /// <summary>
        /// 10 bit per sample 4:2:2 packed color format with similar to YUY2 layout. This format should be mapped to DXGI_FORMAT_Y210. */
        /// </summary>
        Y210 = ((((int)'Y'))+(((int)'2')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// 10 bit per sample 4:4:4 packed color format. This format should be mapped to DXGI_FORMAT_Y410. */
        /// </summary>
        Y410 = ((((int)'Y'))+(((int)'4')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// 16 bit per sample 4:2:2 packed color format with similar to YUY2 layout. This format should be mapped to DXGI_FORMAT_Y216. */
        /// </summary>
        Y216 = ((((int)'Y'))+(((int)'2')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// 16 bit per sample 4:4:4 packed color format. This format should be mapped to DXGI_FORMAT_Y416. */
        /// </summary>
        Y416 = ((((int)'Y'))+(((int)'4')<<8)+(((int)'1')<<16)+(((int)'6')<<24)),

        /// <summary>
        /// Same as NV12 but with weaved V and U values. */
        /// </summary>
        NV21 = ((((int)'N'))+(((int)'V')<<8)+(((int)'2')<<16)+(((int)'1')<<24)),

        /// <summary>
        /// Same as  YV12 except that the U and V plane order is reversed. */
        /// </summary>
        IYUV = ((((int)'I'))+(((int)'Y')<<8)+(((int)'U')<<16)+(((int)'V')<<24)),

        /// <summary>
        /// 10-bit YUV 4:2:0, each component has its own plane. */
        /// </summary>
        I010 = ((((int)'I'))+(((int)'0')<<8)+(((int)'1')<<16)+(((int)'0')<<24)),

        /// <summary>
        /// Alias for the IYUV color format. */
        /// </summary>
        I420 = IYUV,

        /// <summary>
        /// Alias for the RGB4 color format. */
        /// </summary>
        BGRA = RGB4

    }

}