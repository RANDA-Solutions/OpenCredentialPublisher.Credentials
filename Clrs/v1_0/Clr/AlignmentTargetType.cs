using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
// ReSharper disable InconsistentNaming

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// The alignment target type. This uses an enumerated vocabulary. 
    /// </summary>
    [TypeConverter(typeof(CustomEnumConverter<AlignmentTargetType>))]
    [JsonConverter(typeof(StringEnumConverter<AlignmentTargetType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlignmentTargetType
    {
        [EnumMember(Value = "CFItem")]
        CFItem,

        [EnumMember(Value = "CFRubric")]
        CFRubric,

        [EnumMember(Value = "CFRubricCriterion")]
        CFRubricCriterion,

        [EnumMember(Value = "CFRubricCriterionLevel")]
        CFRubricCriterionLevel,

        [EnumMember(Value = "CTDL")]
        CTDL
    }
}
