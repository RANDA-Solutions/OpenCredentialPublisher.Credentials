using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class AchievementCredential : EndorsedCredential
    {
        public static string[] PrimaryTypes = new string[]{ "AchievementCredential", "OpenBadgeCredential" };

        public AchievementCredential()
        {
            Context = new List<string> {
                "https://www.w3.org/ns/credentials/v2",
                "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json",
                "https://w3id.org/security/v3"
            };

            Type = new[]
            {
                "VerifiableCredential",
                "AchievementCredential"
            };
        }

        [JsonProperty("issuer", Order = 8, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("issuer")]
        public new Profile Issuer { get; set; }

        [JsonProperty("credentialSubject", Order = 7, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("credentialSubject")]
        public new AchievementSubject CredentialSubject { get; set; }

        [JsonProperty("evidence", NullValueHandling = NullValueHandling.Ignore, Order = 99), JsonPropertyName("evidence")]
        public Evidence[] Evidence { get; set; }
    }
}
