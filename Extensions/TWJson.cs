using System.Text.Json;

namespace OpenCredentialPublisher.Credentials.Extensions
{
    public class TWJson
    {
        public static T Deserialize<T>(string value) where T : class
        {
            if (string.IsNullOrEmpty(value))
            {
                return (T)null;
            }
            else
            {
                return JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
            }
        }
        public static JsonSerializerOptions IgnoreNulls
        {
            get
            {
                return new JsonSerializerOptions { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull };
            }
        }
    }
}
