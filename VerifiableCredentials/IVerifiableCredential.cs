using System.Collections.Generic;
using JsonSubTypes;
using OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr;
using OpenCredentialPublisher.Credentials.Clrs.v2_0;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ClrCredential), "ClrCredential")]
    [JsonSubtypes.KnownSubType(typeof(AchievementCredential), "AchievementCredential")]
    [JsonSubtypes.KnownSubType(typeof(EndorsementCredential), "EndorsementCredential")]
    [JsonSubtypes.KnownSubType(typeof(VerifiableCredential), "VerifiableCredential")]
    public interface IVerifiableCredential: IVerifiableCredential<object>
    {
        
    }

    public interface IVerifiableCredential<T>
    {
        string[] Context { get; set; }
        BasicProperties[] CredentialSchema { get; set; }
        BasicProperties CredentialStatus { get; set; }
        T CredentialSubject { get; set; }
        string Description { get; set; }
        string ExpirationDate { get; set; }
        string Id { get; set; }
        object Image { get; set; }
        string IssuanceDate { get; set; }
        object Issuer { get; set; }
        string Name { get; set; }
        Proof[] Proof { get; set; }
        BasicProperties RefreshService { get; set; }
        BasicProperties[] TermsOfUse { get; set; }
        string[] Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ClrCredential), "ClrCredential")]
    [JsonSubtypes.KnownSubType(typeof(AchievementCredential), "AchievementCredential")]
    [JsonSubtypes.KnownSubType(typeof(EndorsementCredential), "EndorsementCredential")]
    [JsonSubtypes.KnownSubType(typeof(VerifiableCredential2_0), "VerifiableCredential")]
    public interface IVerifiableCredential2_0 : IVerifiableCredential2_0<object>
    {

    }

    public interface IVerifiableCredential2_0<T>
    {
        string[] Context { get; set; }
        BasicProperties[] CredentialSchema { get; set; }
        BasicProperties CredentialStatus { get; set; }
        T CredentialSubject { get; set; }
        string Description { get; set; }
        string ValidUntil { get; set; }
        string Id { get; set; }
        object Image { get; set; }
        string ValidFrom { get; set; }
        object Issuer { get; set; }
        string Name { get; set; }
        Proof[] Proof { get; set; }
        BasicProperties RefreshService { get; set; }
        BasicProperties[] TermsOfUse { get; set; }
        string[] Type { get; set; }
    }
}