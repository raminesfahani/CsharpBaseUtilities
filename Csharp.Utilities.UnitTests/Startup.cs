using Csharp.Utilities.Tests.DotEnvTests.Samples;
using Microsoft.Extensions.DependencyInjection;

namespace Csharp.Utilities.Tests
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // experimenting, not properly used yet.
            services.AddSingleton<WorkerSettings>();
        }
    }
}
