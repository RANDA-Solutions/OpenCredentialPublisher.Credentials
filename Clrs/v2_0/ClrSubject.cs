using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class ClrSubject: CredentialSubject, ICredentialSubject 
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public List<string> Type { get; set; } = new List<string> { "ClrSubject" };

        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("identifier")]
        public IdentityObject Identifier { get; set; }

        [JsonProperty("achievement", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("achievement")]
        public Achievement[] Achievement { get; set; }

        [JsonProperty("verifiableCredential", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("verifiableCredential")]
        public VerifiableCredential[] VerifiableCredential { get; set; }

        [JsonProperty("association", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("association")]
        public Association[] Association { get; set; }

        /// <summary>
        /// Additional properties of the object
        /// </summary>
        [System.Text.Json.Serialization.JsonExtensionData]
        [JsonPropertyName("additionalProperties"), Newtonsoft.Json.JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<String, Object> AdditionalProperties { get; set; }
    }
}
