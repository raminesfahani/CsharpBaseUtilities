using Csharp.Utilities.Base.JsonConverters;
using Newtonsoft.Json;
using System.Net.Mail;

namespace Csharp.Utilities.Tests.JsonConverters
{
    public class JsonConverterSample
    {
        [JsonProperty("email")]
        [JsonConverter(typeof(MailAddressConverter))]
        public MailAddress Email { get; set; }
    }
}
