using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public class VerifiablePresentation
    {
        [JsonProperty("@context", Order = 1), JsonPropertyName("@context")]
        public List<String> Contexts { get; set; } = new List<string> { "https://www.w3.org/2018/credentials/v1" };

        [JsonProperty("type", Order = 2), JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.Json.SingleOrArrayConverter<string>))]
        public List<String> Types { get; set; } = new List<string> { "VerifiablePresentation" };

        [JsonProperty("holder", Order = 3, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("holder")]
        public String Holder { get; set; }

        [JsonProperty("verifiableCredential", Order = 4, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("verifiableCredential")]
        public List<VerifiableCredential> VerifiableCredential { get; set; }

        [JsonProperty("proof", Order = 5, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("proof")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<Proof>)), System.Text.Json.Serialization.JsonConverter(typeof(Converters.Json.SingleOrArrayConverter<Proof>))]
        public Proof[] Proofs { get; set; }
    }
}
