using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{

    public class ClrCredential: EndorsedCredential
    {
        public ClrCredential()
        {
            Context = new[] {
                "https://www.w3.org/2018/credentials/v1",
                "https://purl.imsglobal.org/spec/clr/v2p0/context-2.0.1.json",
                "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json",
                "https://w3id.org/security/suites/ed25519-2020/v1"
            };

            Type = new[]
            {
                "VerifiableCredential",
                "ClrCredential"
            };
        }

        [JsonProperty("issuer", Order = 8, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("issuer")]
        public new Profile Issuer { get; set; }

        [JsonProperty("credentialSubject", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("credentialSubject")]
        public new ClrSubject CredentialSubject { get; set; }

        [JsonProperty("partial", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("partial")]
        public bool Partial { get; set; }
    }
}
