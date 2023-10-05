using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public class VerifiablePresentation
    {
        [JsonProperty("@context", Order = 1), JsonPropertyName("@context")]
        public List<string> Contexts { get; set; }

        [JsonProperty("type", Order = 2), JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(Converters.Json.SingleOrArrayConverter<string>))]
        public string[] Types { get; set; } = new string[] { "VerifiablePresentation" };

        [JsonProperty("holder", NullValueHandling = NullValueHandling.Ignore, Order = 3), JsonPropertyName("holder")]
        public string Holder { get; set; }

        [JsonProperty("verifiableCredential", Order = 4), JsonPropertyName("verifiableCredential")]
        public List<object> VerifiableCredential { get; set; }

        [JsonProperty("proof", Order = 5, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("proof")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<Proof>)), System.Text.Json.Serialization.JsonConverter(typeof(Converters.Json.SingleOrArrayConverter<Proof>))]
        public Proof[] Proofs { get; set; }
    }
}
