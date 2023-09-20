using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// Join class for many-to-many relationship.
    /// </summary>
    [NotMapped]
    public class AchievementClr
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AchievementClrId { get; set; }
        [ForeignKey(nameof(Clr))]
        public int ClrKey { get; set; }
        public virtual ClrDType Clr { get; set; }

        [ForeignKey(nameof(Achievement))]
        public int AchievementKey { get; set; }
        public virtual AchievementDType Achievement { get; set; }
    }
}