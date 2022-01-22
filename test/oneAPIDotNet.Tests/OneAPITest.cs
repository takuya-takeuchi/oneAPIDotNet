using Xunit;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet.Tests
{

    public sealed partial class OneAPITest : TestBase
    {

        #region Fields

        private const string ResultDirectory = "Result";

        private const string TestImageDirectory = "TestImages";

        #endregion

        [Fact]
        public void GetNativeVersion()
        {
            var version = OneAPI.GetNativeVersion();
            Assert.True(!string.IsNullOrWhiteSpace(version));
        }

    }

}
