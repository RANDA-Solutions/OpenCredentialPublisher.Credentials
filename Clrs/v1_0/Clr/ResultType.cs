using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// The result type. This uses an enumerated vocabulary. 
    /// </summary>
    [TypeConverter(typeof(CustomEnumConverter<ResultType>))]
    [JsonConverter(typeof(StringEnumConverter<ResultType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResultType
    {
        [EnumMember(Value = "GradePointAverage")]
        GradePointAverage,

        [EnumMember(Value = "LetterGrade")]
        LetterGrade,

        [EnumMember(Value = "Percent")]
        Percent,

        [EnumMember(Value = "PerformanceLevel")]
        PerformanceLevel,

        [EnumMember(Value = "PredictedScore")]
        PredictedScore,

        [EnumMember(Value = "Result")]
        Result,

        [EnumMember(Value = "RawScore")]
        RawScore,

        [EnumMember(Value = "RubricCriterion")]
        RubricCriterion,

        [EnumMember(Value = "RubricCriterionLevel")]
        RubricCriterionLevel,

        [EnumMember(Value = "RubricScore")]
        RubricScore,

        [EnumMember(Value = "ScaledScore")]
        ScaledScore
    }
}
