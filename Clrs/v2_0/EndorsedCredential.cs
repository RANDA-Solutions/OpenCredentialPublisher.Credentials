using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsedCredential: VerifiableCredential2_0 
    {
        [JsonProperty("endorsement", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsement")]
        public EndorsementCredential[] Endorsement { get; set; }

        [JsonProperty("endorsementJwt", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsementJwt")]
        public string[] EndorsementJwt { get; set; }

        [JsonProperty("awardedDate", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("awardedDate")]
        public string AwardedDate { get; set; }

        [System.Text.Json.Serialization.JsonExtensionData]
        [JsonPropertyName("additionalProperties"), JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> AdditionalProperties { get; set; }
    }
}
