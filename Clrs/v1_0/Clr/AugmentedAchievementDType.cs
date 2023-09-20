using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
// ReSharper disable UnusedMember.Global

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedAchievementDType : AchievementDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int AchievementKey { get; set; }

        [JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public virtual IList<AchievementClr> AchievementClrs { get; set; }
    }
}
