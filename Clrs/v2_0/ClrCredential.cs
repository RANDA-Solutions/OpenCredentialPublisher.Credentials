using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{

    public class ClrCredential: EndorsedCredential
    {
        public ClrCredential()
        {
            Context = new List<object> {
                "https://www.w3.org/ns/credentials/v2",
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

        // Currently this property is not validating properly and is getting left out of the proof 
        // when the CLR 2.0 Validator is run.  This is a known issue and will be addressed in a future release.
        //[JsonProperty("partial", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("partial")]
        [System.Text.Json.Serialization.JsonIgnore(), Newtonsoft.Json.JsonIgnore]
        public bool Partial { get; set; }
    }
}
