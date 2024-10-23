using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsedCredential: VerifiableCredential 
    { 
        [JsonProperty("endorsement", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsement")]
        public EndorsementCredential[] Endorsement { get; set; }

        [JsonProperty("endorsementJwt", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsementJwt")]
        public string[] EndorsementJwt { get; set; }

        [JsonProperty("awardedDate", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("awardedDate")]
        public string AwardedDate { get; set; }

        [JsonProperty("validFrom", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validUntil", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("validUntil")]
        public string ValidUntil { get; set; }
    }
}
