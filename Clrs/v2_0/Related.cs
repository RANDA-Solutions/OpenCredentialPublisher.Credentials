﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public class Related
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public List<string> Type { get; set; }

        [JsonProperty("@language", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("@language")]
        public string Language { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
