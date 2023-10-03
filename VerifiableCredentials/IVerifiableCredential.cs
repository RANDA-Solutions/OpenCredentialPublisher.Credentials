using System.Collections.Generic;
using OpenCredentialPublisher.Credentials.Clrs.v2_0;

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
        Profile Issuer { get; set; }
        string Name { get; set; }
        Proof[] Proof { get; set; }
        BasicProperties RefreshService { get; set; }
        BasicProperties[] TermsOfUse { get; set; }
        string[] Type { get; set; }
    }
}