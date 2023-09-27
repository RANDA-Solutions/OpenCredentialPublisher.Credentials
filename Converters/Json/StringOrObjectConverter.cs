using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Converters.Json
{
    public class StringOrObjectConverter<T> : JsonConverter<object> where T : class
    {

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(object) || objectType == typeof(T) || objectType == typeof(String));
        }

        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                if (jsonDoc.RootElement.ValueKind == JsonValueKind.Object)
                {
                    return JsonSerializer.Deserialize<T>(jsonDoc.RootElement.GetRawText(), options);
                }
                return jsonDoc.RootElement.ToString();
            }
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            if (value is T tvalue)
            {
                var jsonDocument = JsonDocument.Parse(JsonSerializer.Serialize(tvalue, options));
                jsonDocument.WriteTo(writer);
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
