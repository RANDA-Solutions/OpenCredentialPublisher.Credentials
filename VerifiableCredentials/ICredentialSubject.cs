using JsonSubTypes;
using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr;
using System;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ClrSubject), "Clr")]
    [JsonSubtypes.KnownSubType(typeof(ClrSetSubject), "ClrSet")]
    [JsonSubtypes.KnownSubType(typeof(CatchAllSubject), "*")]
    public interface ICredentialSubject
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("id")]
        String Id { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        public string[] Type { get; set; }
    }
}
