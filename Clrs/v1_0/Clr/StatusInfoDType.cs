﻿using Newtonsoft.Json;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    public class StatusInfoDType
    {
        [JsonProperty("imsx_codeMajor", Required = Required.Always)]
        public CodeMajorEnum CodeMajor { get; set; }
        [JsonProperty("imsx_severity", Required = Required.Always)]
        public CodeSeverityEnum Severity { get; set; }
        [JsonProperty("imsx_description")]
        public string Description { get; set; }
        [JsonProperty("imsx_codeMinor")]
        public CodeMinorDType CodeMinor { get; set; }
    }

}
