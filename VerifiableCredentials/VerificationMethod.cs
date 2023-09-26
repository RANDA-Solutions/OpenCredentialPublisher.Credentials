using Newtonsoft.Json;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public class VerificationMethod
    {
        [JsonProperty("id", Order = 1), System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonProperty("type", Order = 2), System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
