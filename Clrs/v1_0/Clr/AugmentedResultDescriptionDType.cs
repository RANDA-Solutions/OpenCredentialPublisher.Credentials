using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedResultDescriptionDType : ResultDescriptionDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int ResultDescriptionKey { get; set; }

        [ForeignKey(nameof(Achievement)), JsonIgnore, Newtonsoft.Json.JsonIgnore, Display(Name = "Achievement")]
        public int? AchievementKey { get; set; }

        [JsonIgnore, Newtonsoft.Json.JsonIgnore, Display(Name = "Achievement")]
        public virtual AchievementDType Achievement { get; set; }
    }
}
