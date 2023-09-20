using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
// ReSharper disable UnusedMember.Global

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedClrPayloadDType : ClrPayloadDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int ClrPayloadKey { get; set; }
    }
}
