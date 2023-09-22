using Newtonsoft.Json.Linq;
using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [TypeConverter(typeof(CustomEnumConverter<AssociationTypeEnum>))]
    [JsonConverter(typeof(StringEnumConverter<AssociationTypeEnum>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociationTypeEnum
    {
        [EnumMember(Value = "exactMatchOf")]
        exactMatchOf = 1,
        [EnumMember(Value = "exemplar")]
        exemplar = 2,
        [EnumMember(Value = "hasSkillLevel")]
        hasSkillLevel = 3,
        [EnumMember(Value = "isChildOf")]
        isChildOf = 4,
        [EnumMember(Value = "isParentOf")]
        isParentOf = 5,
        [EnumMember(Value = "isPartOf")]
        isPartOf = 6,
        [EnumMember(Value = "isPeerOf")]
        isPeerOf = 7,
        [EnumMember(Value = "isRelatedTo")]
        isRelatedTo = 8,
        [EnumMember(Value = "precedes")]
        precedes = 9,
        [EnumMember(Value = "replacedBy")]
        replacedBy = 10
    }
}
