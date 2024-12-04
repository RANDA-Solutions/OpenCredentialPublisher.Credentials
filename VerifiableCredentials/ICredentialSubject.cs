using Newtonsoft.Json;
using System;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public interface ICredentialSubject
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("id")]
        String Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        public string[] Type { get; set; }
    }
}
