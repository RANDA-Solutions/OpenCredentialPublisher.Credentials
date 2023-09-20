using Newtonsoft.Json;
using System;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    public class Proof
    {
        [JsonProperty("type", Order = 1)]
        public string Type { get; set; }

        [JsonProperty("created", Order = 2)]
        [JsonConverter(typeof(DateConverter<DateTime>), "o")]
        public DateTime Created { get; set; }

        [JsonProperty("proofPurpose", Order = 3)]
        public string ProofPurpose { get; set; }

        [JsonProperty("verificationMethod", Order = 4)]
        public string VerificationMethod { get; set; }

        [JsonProperty("signature", Order = 7, NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        [JsonProperty("nonce", Order = 9, NullValueHandling = NullValueHandling.Ignore)]
        public string Nonce { get; set; }

        [JsonProperty("proofValue", Order = 8, NullValueHandling = NullValueHandling.Ignore)]
        public string ProofValue { get; set; }

        [JsonProperty("challenge", Order = 6, NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; }

        [JsonProperty("domain", Order = 5, NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }
    }
}
