namespace OneAPIDotNet.VPL
{

    public enum MfxCodec
    {

        /// <summary>
        /// AVC, H.264, or MPEG-4, part 10 codec.
        /// </summary>
        AVC = ((((int)'A'))+(((int)'V')<<8)+(((int)'C')<<16)+(((int)' ')<<24)),

        /// <summary>
        /// HEVC codec.
        /// </summary>
        HEVC = ((((int)'H'))+(((int)'E')<<8)+(((int)'V')<<16)+(((int)'C')<<24)),

        /// <summary>
        /// MPEG-2 codec.
        /// </summary>
        MPEG2 = ((((int)'M'))+(((int)'P')<<8)+(((int)'G')<<16)+(((int)'2')<<24)),

        /// <summary>
        /// VC-1 codec.
        /// </summary>
        VC1 = ((((int)'V'))+(((int)'C')<<8)+(((int)'1')<<16)+(((int)' ')<<24)),

        CAPTURE = ((((int)'C'))+(((int)'A')<<8)+(((int)'P')<<16)+(((int)'T')<<24)),

        /// <summary>
        /// VP9 codec.
        /// </summary>
        VP9 = ((((int)'V'))+(((int)'P')<<8)+(((int)'9')<<16)+(((int)' ')<<24)),

        /// <summary>
        /// AV1 codec.
        /// </summary>
        AV1 = ((((int)'A'))+(((int)'V')<<8)+(((int)'1')<<16)+(((int)' ')<<24)),

    }

}