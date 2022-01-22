using Xunit;

using OneAPIDotNet.VPL;

// ReSharper disable once CheckNamespace
namespace OneAPIDotNet.Tests.VPL
{

    public sealed class MfxInitializationParamTest : TestBase
    {

        [Fact]
        public void CreateAndDelete()
        {
            var param = new MfxInitializationParam();
            this.DisposeAndCheckDisposedState(param);
        }

    }

}
