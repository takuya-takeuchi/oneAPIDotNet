using Xunit;

using OneAPIDotNet.VPL;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet.Tests.VPL
{

    public sealed class MfxVersionTest : TestBase
    {

        [Fact]
        public void CreateAndDelete()
        {
            var version = new MfxVersion();
            this.DisposeAndCheckDisposedState(version);
        }

        [Fact]
        public void Major()
        {
            const ushort expected = 10;
            var version = new MfxVersion
            {
                Major = expected
            };
            Assert.Equal(expected, version.Major);
            this.DisposeAndCheckDisposedState(version);
        }

        [Fact]
        public void Minor()
        {
            const ushort expected = 2;
            var version = new MfxVersion
            {
                Minor = expected
            };
            Assert.Equal(expected, version.Minor);
            this.DisposeAndCheckDisposedState(version);
        }

        [Fact]
        public void Version()
        {
            const uint expected = 2021;
            var version = new MfxVersion
            {
                Version = expected
            };
            Assert.Equal(expected, version.Version);
            this.DisposeAndCheckDisposedState(version);
        }

    }

}
