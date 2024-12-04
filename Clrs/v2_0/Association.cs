using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class Association
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("type")]
        public string Type { get; set; } = "Association";

        [JsonProperty("associationType", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("associationType")]
        [Newtonsoft.Json.JsonConverter(typeof(EnumAsStringConverter<AssociationTypeEnum>))]
        [System.Text.Json.Serialization.JsonConverter(typeof(StringEnumConverter<AssociationTypeEnum>))]
        public AssociationTypeEnum AssociationType { get; set; }

        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("targetId", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("targetId")]
        public string TargetId { get; set; }
    }
}
