
using System.Runtime.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v2_0
{
    public enum AssociationTypeEnum
    {
        [EnumMember(Value = nameof(exactMatchOf))]
        exactMatchOf,
        [EnumMember(Value = nameof(isChildOf))]
        isChildOf,
        [EnumMember(Value = nameof(isParentOf))]
        isParentOf,
        [EnumMember(Value = nameof(isPartOf))]
        isPartOf,
        [EnumMember(Value = nameof(isPeerOf))]
        isPeerOf,
        [EnumMember(Value = nameof(isRelatedTo))]
        isRelatedTo,
        [EnumMember(Value = nameof(precedes))]
        precedes,
        [EnumMember(Value = nameof(replacedBy))]
        replacedBy
    }
}
