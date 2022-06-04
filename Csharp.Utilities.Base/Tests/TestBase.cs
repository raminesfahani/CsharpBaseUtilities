using Csharp.Utilities.Base.Tools;
using Xunit.Abstractions;

namespace Csharp.Utilities.Base.Tests
{
    public abstract class TestBase
    {
        protected static string EnvPath => ".env";
        protected ITestOutputHelper Output { get; }

        public TestBase(ITestOutputHelper outputHelper)
        {
            Output = outputHelper;
        }

        protected void LoadEnv()
        {
            DotEnv.Load(EnvPath);
        }
    }
}
