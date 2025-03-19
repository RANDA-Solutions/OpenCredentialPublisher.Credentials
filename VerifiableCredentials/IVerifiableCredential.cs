using OpenCredentialPublisher.Credentials.Clrs.v2_0;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.VerifiableCredentials
{
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

    public interface IVerifiableCredential2_0 : IVerifiableCredential2_0<object>
    {

    }

    public interface IVerifiableCredential2_0<T>
    {
        List<object> Context { get; set; }
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