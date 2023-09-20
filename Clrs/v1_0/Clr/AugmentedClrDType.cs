using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [NotMapped]
    public class AugmentedClrDType : ClrDType
    {
        [Key, JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public int ClrKey { get; set; }
        
        [JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public virtual IList<AchievementClr> AchievementClrs { get; set; }

        [JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public virtual IList<AssertionClr> AssertionClrs { get; set; }
    }
}
