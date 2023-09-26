﻿using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public class ClrSubject: ClrDType, ICredentialSubject
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore), System.Text.Json.Serialization.JsonPropertyName("type")]
        [Newtonsoft.Json.JsonConverter(typeof(SingleOrArrayConverter<string>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<string>))]
        public new List<string> Type { get; set; }
    }
}
