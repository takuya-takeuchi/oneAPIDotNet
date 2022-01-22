using OneAPIDotNet.VPL;
using Xunit;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet.Tests.VPL
{

    public sealed partial class OneVPLTest : TestBase
    {

        #region Fields

        private const string ResultDirectory = "Result";

        private const string TestImageDirectory = "TestImages";

        #endregion

        #region MfxDefs

        [Fact]
        public void MFXLegacyVersion()
        {
            const uint expected = 1034;
            Assert.Equal(expected, OneVPL.MFXLegacyVersion);
        }

        [Fact]
        public void MFXVersion()
        {
            const uint expected = 2002;
            Assert.Equal(expected, OneVPL.MFXVersion);
        }

        [Fact]
        public void MFXVersionMajor()
        {
            const uint expected = 2;
            Assert.Equal(expected, OneVPL.MFXVersionMajor);
        }

        [Fact]
        public void MFXVersionMinor()
        {
            const uint expected = 2;
            Assert.Equal(expected, OneVPL.MFXVersionMinor);
        }

        #endregion

        #region MfxDispatcher

        [Fact]
        public void MFXLoadAndUnload()
        {
            var loader = OneVPL.MFXLoad();
            Assert.NotNull(loader);
            OneVPL.MFXUnload(loader);
            this.DisposeAndCheckDisposedState(loader);
        }

        #endregion

        #region MfxSession

        [Fact]
        public void MFXInit()
        {
            const MfxStatus expected = MfxStatus.ErrorNone;
            var impl = MfxImpl.Software;
            var version = new MfxVersion
            {
                Major = 1,
                Minor = 0
            };

            Assert.Equal(expected, OneVPL.MFXInit(impl, version, out var _));
            this.DisposeAndCheckDisposedState(version);
        }

        #endregion

    }

}
