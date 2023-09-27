using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsementSubject: CredentialSubject
    {

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Credentials.Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public string[] Type { get; set; }

        [JsonProperty("endorsementComment", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsementComment")]
        public string EndorsementComment { get; set; }
    }
}
