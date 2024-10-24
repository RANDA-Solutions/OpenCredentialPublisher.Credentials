using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Converters.Json
{
    public class SingleOrArrayConverter<T> : JsonConverter<T[]> where T: class
    {

        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T[]));
        }

        public override T[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var list = new List<T>();
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                if (jsonDoc.RootElement.ValueKind == JsonValueKind.Array)
                {
                    foreach(var element in jsonDoc.RootElement.EnumerateArray())
                    {
                        list.Add(JsonSerializer.Deserialize<T>(element.GetRawText(), options));
                    }
                }
                else if (jsonDoc.RootElement.ValueKind == JsonValueKind.Object)
                {
                    list.Add(JsonSerializer.Deserialize<T>(jsonDoc.RootElement.GetRawText(), options));
                }
            }
            
            return list.Count > 0 ? list.ToArray() : null;
        }

        public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
        {
            if (value?.Length == 1)
            {
                var singleValue = value[0];

                var jsonDocument = JsonDocument.Parse(JsonSerializer.Serialize(singleValue, options));
                jsonDocument.WriteTo(writer);
            }
            else if (value?.Length > 1)
            {
                writer.WriteStartArray();
                foreach(var item in value)
                {
                    var jsonDocument = JsonDocument.Parse(JsonSerializer.Serialize(item, options));
                    jsonDocument.WriteTo(writer);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }
}
