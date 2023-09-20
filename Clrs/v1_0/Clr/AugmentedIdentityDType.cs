using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedIdentityDType :IdentityDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int IdentityKey { get; set; }
    }
}
