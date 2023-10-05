using OpenCredentialPublisher.Credentials.Attributes;
using System;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    [JsonType("*")]
    public class CatchAllSubject : CredentialSubject
    {
        [System.Text.Json.Serialization.JsonExtensionData]
        [System.Text.Json.Serialization.JsonPropertyName("additionalProperties"), Newtonsoft.Json.JsonProperty("additionalProperties")]
        public Dictionary<String, Object> AdditionalProperties { get; set; }
    }
}
