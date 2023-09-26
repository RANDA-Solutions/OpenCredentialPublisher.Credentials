using JsonSubTypes;
using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Attributes;
using System;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{

    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ClrSubject), "Clr")]
    [JsonSubtypes.KnownSubType(typeof(ClrSetSubject), "ClrSet")]
    [JsonSubtypes.KnownSubType(typeof(CatchAllSubject), "*")]
    public interface ICredentialSubject
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("id")]
        String Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        public List<string> Type { get; set; }
    }
    public abstract class CredentialSubject : ICredentialSubject
    {
        public String Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public List<string> Type { get; set; }
    }

    [JsonType("*")]
    public class CatchAllSubject : CredentialSubject
    {
        [System.Text.Json.Serialization.JsonExtensionData]
        [System.Text.Json.Serialization.JsonPropertyName("additionalProperties"), Newtonsoft.Json.JsonProperty("additionalProperties")]
        public Dictionary<String, Object> AdditionalProperties { get; set; }
    }
}
