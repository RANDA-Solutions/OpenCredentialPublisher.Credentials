using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsementCredential: VerifiableCredential2_0
    {
        public EndorsementCredential()
        {
            Context = new[] {
                "https://www.w3.org/ns/credentials/v2",
                "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json",
                "https://w3id.org/security/suites/ed25519-2020/v1"
            };

            Type = new[]
            {
                "VerifiableCredential",
                "EndorsementCredential"
            };
        }

        [JsonProperty("issuer", Order = 8, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("issuer")]
        public new Profile Issuer { get; set; }

        public new EndorsementSubject CredentialSubject { get; set; }

        [JsonProperty("awardedDate", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("awardedDate")]
        public string AwardedDate { get; set; }

        [System.Text.Json.Serialization.JsonExtensionData]
        [JsonPropertyName("additionalProperties"), JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> AdditionalProperties { get; set; }
    }
}
