using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    public class ClrSetSubject : ClrSetDType, ICredentialSubject
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        [JsonConverter(typeof(Credentials.Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public new string[] Type { get; set; }
    }
}
