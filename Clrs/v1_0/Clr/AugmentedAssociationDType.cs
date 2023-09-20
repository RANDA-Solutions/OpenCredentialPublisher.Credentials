using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedAssociationDType : AssociationDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int AssociationKey { get; set; }

        [ForeignKey(nameof(Achievement)), JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int? AchievementKey { get; set; }

        [JsonIgnore, Newtonsoft.Json.JsonIgnore, Display(Name = "Achievement")]
        public virtual AchievementDType Achievement { get; set; }
    }
}
