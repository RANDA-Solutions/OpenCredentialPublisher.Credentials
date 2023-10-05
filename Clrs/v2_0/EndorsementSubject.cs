using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsementSubject: CredentialSubject
    {
        public EndorsementSubject() {
            Type = new[] { "EndorsementSubject" };
        }

        [JsonProperty("endorsementComment", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsementComment")]
        public string EndorsementComment { get; set; }
    }
}
