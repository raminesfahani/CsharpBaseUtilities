using System.IO;
using Xunit;
using Xunit.Abstractions;
using Newtonsoft.Json;
using System.Net.Mail;
using Csharp.Utilities.Base.Tests;

namespace Csharp.Utilities.Tests.JsonConverters
{
    public class JsonConverterTests : TestBase
    {
        public JsonConverterTests(ITestOutputHelper outputHelper) : base(outputHelper) { }

        private char Ds => Path.DirectorySeparatorChar;

        [Fact]
        public void ParseMailAddressTest()
        {
            string jsonFile = File.ReadAllText($"JsonConverters{Ds}JsonConverterSample.json");
            JsonConverterSample sample = JsonConvert.DeserializeObject<JsonConverterSample>(jsonFile);

            Output.WriteLine($"Sample json file was parsed to email: " + sample.Email);
            Assert.NotNull(sample.Email);
            Assert.True(sample.Email.ToString().Length > 0);
        }
    }
}
