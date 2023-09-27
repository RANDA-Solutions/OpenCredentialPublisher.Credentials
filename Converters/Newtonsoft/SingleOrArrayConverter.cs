using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace OpenCredentialPublisher.Credentials.Converters.Newtonsoft
{
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>) || objectType.IsArray);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            
            if (typeof(T).IsAbstract)
            {
                var list = new List<T>();
                if (token.Type == JTokenType.Object)
                    list.Add(serializer.Deserialize<T>(token.CreateReader()));
                if (token.Type == JTokenType.Array)
                {
                    foreach (var item in token as JArray)
                        list.Add(serializer.Deserialize<T>(item.CreateReader()));
                }
                if (list.Count > 0)
                    return objectType.IsArray ? list.ToArray() : list;
            }

            if (token.Type == JTokenType.Array)
            {
                var list = token.ToObject<List<T>>();
                return objectType.IsArray ? list.ToArray() : list;
            }

            var singleObjectList = new List<T> { token.ToObject<T>() };
            return objectType.IsArray ? singleObjectList.ToArray() : singleObjectList;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value.GetType().IsArray)
            {
                var array = (T[])value;
                if (array.Length == 1)
                {
                    value = array[0];
                }
            }
            else
            {
                List<T> list = (List<T>)value;
                if (list.Count == 1)
                {
                    value = list[0];
                }
            }
            serializer.Serialize(writer, value);
        }
    }
}
