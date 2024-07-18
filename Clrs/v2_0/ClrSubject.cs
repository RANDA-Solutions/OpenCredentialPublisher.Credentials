using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class ClrSubject: CredentialSubject, ICredentialSubject 
    {
        public ClrSubject()
        {
            Type = new string[] { "ClrSubject" };
        }

        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("identifier")]
        public IdentityObject Identifier { get; set; }

        [JsonProperty("achievement", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("achievement")]
        public Achievement[] Achievement { get; set; }

        [JsonProperty("verifiableCredential", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("verifiableCredential")]
        //[Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<object>))]
        public object[] VerifiableCredential { get; set; }

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
