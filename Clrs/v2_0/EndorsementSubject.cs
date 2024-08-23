using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.VerifiableCredentials;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class EndorsementSubject: CredentialSubject, ICredentialSubject
    {
        public EndorsementSubject() {
        }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        public new String[] Type { get; set; } = new[] { "EndorsementSubject" };

        [JsonProperty("endorsementComment", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("endorsementComment")]
        public string EndorsementComment { get; set; }
    }
}
