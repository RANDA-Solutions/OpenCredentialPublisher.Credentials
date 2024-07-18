using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenCredentialPublisher.Credentials.Converters.Newtonsoft
{
    public class SingleObjectConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType != typeof(List<T>) && !objectType.IsArray);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            try
            {
                var result = JsonConvert.DeserializeObject<T>(token.ToString(), new JsonSerializerSettings
                {
                    Error = (sender, args) =>
                    {
                        Debug.WriteLine(args.ErrorContext.Error.Message);
                        args.ErrorContext.Handled = true;
                    }
                });
                if (token.Type == JTokenType.Object)
                    return serializer.Deserialize<T>(token.CreateReader());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return default;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
