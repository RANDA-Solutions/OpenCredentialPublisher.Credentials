using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
// ReSharper disable UnusedMember.Global

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedCryptographicKeyDType : CryptographicKeyDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int CryptographicKeyKey { get; set; }
    }
}
