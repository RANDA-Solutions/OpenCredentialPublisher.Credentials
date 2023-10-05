using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class AchievementCredential : EndorsedCredential
    {
        public static string[] PrimaryTypes = new string[]{ "AchievementCredential", "OpenBadgeCredential" };

        public AchievementCredential()
        {
            Context = new[] {
                "https://www.w3.org/2018/credentials/v1",
                "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.2.json",
                "https://w3id.org/security/suites/ed25519-2020/v1"
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

        [JsonProperty("awardedDate", Order = 98, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("awardedDate")]
        public string AwardedDate { get; set; }

        [JsonProperty("evidence", NullValueHandling = NullValueHandling.Ignore, Order = 99), JsonPropertyName("evidence")]
        public Evidence[] Evidence { get; set; }
    }
}
