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
        public String Type { get; set; } = "VerifiablePresentation";

        [JsonProperty("verifiableCredential", Order = 3), JsonPropertyName("verifiableCredential")]
        public List<object> VerifiableCredential { get; set; }

        [JsonProperty("proof", Order = 4, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("proof")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<Proof>))]
        public List<Proof> Proofs { get; set; }
    }
}
