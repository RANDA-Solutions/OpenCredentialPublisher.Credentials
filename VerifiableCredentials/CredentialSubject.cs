using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public abstract class CredentialSubject : ICredentialSubject
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public string[] Type { get; set; }
    }
}
