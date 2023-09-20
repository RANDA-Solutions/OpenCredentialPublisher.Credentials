using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    public enum AssociationTypeEnum
    {
        exactMatchOf = 1,
        exemplar = 2,
        hasSkillLevel = 3,
        isChildOf = 4,
        isParentOf = 5,
        isPartOf = 6,
        isPeerOf = 7,
        isRelatedTo = 8,
        precedes = 9,
        replacedBy = 10
    }
}
