using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class RevocationDocument
    {
        [JsonProperty("statuses"), JsonPropertyName("statuses")]
        public Dictionary<string, string> Statuses { get; set; }

        [JsonProperty("revocations"), JsonPropertyName("revocations")]
        public List<Revocation> Revocations { get; set; }
    }

    [NotMapped]
    public class Revocation
    {
        [JsonProperty("id"), JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonProperty("status"), JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
