using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace OpenCredentialPublisher.Credentials.Converters.Newtonsoft
{
    public class StringOrObjectConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T) || objectType == typeof(String));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Object)
                return serializer.Deserialize<T>(token.CreateReader());
            return token.Value<string>();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
