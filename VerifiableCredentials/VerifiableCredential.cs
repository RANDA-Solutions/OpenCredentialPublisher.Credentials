using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using OpenCredentialPublisher.Credentials.Clrs.v1_0.Interfaces;
using OpenCredentialPublisher.Credentials.Clrs.v1_0.Utilities;
using OpenCredentialPublisher.Credentials.Clrs.v2_0;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using OpenCredentialPublisher.Credentials.Cryptography;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{

    //public class VerifiableCredential
    //{
    //    [JsonProperty("@context", Order = 1)]
    //    public List<String> Contexts { get; set; }

    //    [JsonProperty("id", Order = 2, NullValueHandling = NullValueHandling.Ignore)]
    //    public String Id { get; set; }

    //    [JsonProperty("type", Order = 3)]
    //    public List<String> Types { get; set; }

    //    [JsonProperty("name", Order = 10)]
    //    public string Name { get; set; }

    //    [JsonProperty("issuer", Order = 4)]
    //    public String Issuer { get; set; }

    //    [JsonProperty("issuanceDate", Order = 5)]
    //    [JsonConverter(typeof(DateConverter<DateTime>), "o")]
    //    public DateTime IssuanceDate { get; set; }

    //    [JsonProperty("credentialSubject", Order = 6)]
    //    [JsonConverter(typeof(SingleOrArrayConverter<ICredentialSubject>))]
    //    public List<ICredentialSubject> CredentialSubjects { get; set; }

    //    [JsonProperty("credentialStatus", Order = 7, NullValueHandling = NullValueHandling.Ignore)]
    //    public CredentialStatus CredentialStatus { get; set; }

    //    [JsonProperty("proof", Order = 8, NullValueHandling = NullValueHandling.Ignore)]
    //    public virtual Proof Proof { get; set; }

    //}

    public class VerifiableCredential : IVerifiableCredential

    {
        [JsonProperty("@context", Order = 1, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("@context")]
        public string[] Context { get; set; }

        [JsonProperty("type", Order = 2, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("type")]
        public string[] Type { get; set; }

        [JsonProperty("id", Order = 3, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("name", Order = 4, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("description", Order = 5, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("image", Order = 6, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("image")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.Newtonsoft.StringOrObjectConverter<Image>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.StringOrObjectConverter<Image>))]
        public object Image { get; set; }

        [JsonProperty("credentialSubject", Order = 7, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("credentialSubject")]
        public virtual object CredentialSubject { get; set; }

        [JsonProperty("issuer", Order = 8, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("issuer")]
        public Profile Issuer { get; set; }

        [JsonProperty("issuanceDate", Order = 9, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("issuanceDate")]
        public string IssuanceDate { get; set; }

        [JsonProperty("expirationDate", Order = 10, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("proof", Order = 11, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("proof")]
        [Newtonsoft.Json.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Newtonsoft.SingleOrArrayConverter<Proof>)), System.Text.Json.Serialization.JsonConverter(typeof(OpenCredentialPublisher.Credentials.Converters.Json.SingleOrArrayConverter<Proof>))]
        public Proof[] Proof { get; set; }

        [JsonProperty("credentialSchema", Order = 12, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("credentialSchema")]
        public BasicProperties[] CredentialSchema { get; set; }

        [JsonProperty("credentialStatus", Order = 13, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("credentialStatus")]
        public BasicProperties CredentialStatus { get; set; }

        [JsonProperty("refreshService", Order = 14, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("refreshService")]
        public BasicProperties RefreshService { get; set; }

        [JsonProperty("termsOfUse", Order = 15, NullValueHandling = NullValueHandling.Ignore), JsonPropertyName("termsOfUse")]
        public BasicProperties[] TermsOfUse { get; set; }

        public void SetIssuanceDate(DateTime issuanceDate) => IssuanceDate = issuanceDate.ToString("o");
        public void SetExpirationDate(DateTime expirationDate) => ExpirationDate = expirationDate.ToString("o");
    }
}
