using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// The achievement type. This uses an enumerated vocabulary. 
    /// </summary>
    [TypeConverter(typeof(CustomEnumConverter<AchievementType>))]
    [JsonConverter(typeof(StringEnumConverter<AchievementType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AchievementType
    {
        [EnumMember(Value = "Achievement")]
        Achievement,

        [EnumMember(Value = "AssessmentResult")]
        AssessmentResult,

        [EnumMember(Value = "Award")]
        Award,

        [EnumMember(Value = "Badge")]
        Badge,

        [EnumMember(Value = "Certificate")]
        Certificate,

        [EnumMember(Value = "Certification")]
        Certification,

        [EnumMember(Value = "Course")]
        Course,

        [EnumMember(Value = "CommunityService")]
        CommunityService,

        [EnumMember(Value = "Competency")]
        Competency,

        [EnumMember(Value = "Co-Curricular")]
        CoCurricular,

        [EnumMember(Value = "Degree")]
        Degree,

        [EnumMember(Value = "Diploma")]
        Diploma,

        [EnumMember(Value = "Fieldwork")]
        Fieldwork,

        [EnumMember(Value = "License")]
        License,

        [EnumMember(Value = "Membership")]
        Membership
    }
}
