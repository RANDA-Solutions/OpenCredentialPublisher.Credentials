using OpenCredentialPublisher.Credentials.Converters.Json;
using OpenCredentialPublisher.Credentials.Converters.Newtonsoft;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    [TypeConverter(typeof(CustomEnumConverter<VerificationTypeEnum>))]
    [JsonConverter(typeof(StringEnumConverter<VerificationTypeEnum>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum VerificationTypeEnum
    {
        [EnumMember(Value = "Hosted")]
        Hosted = 1,
        [EnumMember(Value = "Signed")]
        Signed = 2,
        [EnumMember(Value = "Verification")]
        Verification = 3
    }

}
