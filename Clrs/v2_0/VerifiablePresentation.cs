using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class VerifiablePresentation
    {
        [JsonProperty("@context", Order = 1), JsonPropertyName("@context")]
        public List<String> Contexts { get; set; }

        [JsonProperty("type", Order = 2), JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Credentials.Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public string[] Types { get; set; } = new string[] { "VerifiablePresentation" };

        [JsonProperty("holder", NullValueHandling = NullValueHandling.Ignore, Order = 3), JsonPropertyName("holder")]
        public String Holder { get; set; } 

        [JsonProperty("verifiableCredential", Order = 4), JsonPropertyName("verifiableCredential")]
        public List<object> VerifiableCredential { get; set; }

        [JsonProperty("proof", Order = 5, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("proof")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<Proof>))]
        public Proof[] Proofs { get; set; }
    }
}
