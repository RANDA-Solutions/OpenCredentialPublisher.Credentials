using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenCredentialPublisher.Credentials.Attributes;
using OpenCredentialPublisher.Credentials.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OpenCredentialPublisher.Credentials.Converters.Newtonsoft
{
    //public class PolymorphicConverter<TItem, TList> : JsonConverter<TList>
    //    where TItem : notnull
    //    where TList : IList<TItem>, new()
    //{

    //    public string PolymorphicDiscriminator { get; set; } = "type";
    //    public bool PolymorphicDiscriminatorIsArray { get; set; } = false;

    //    public PolymorphicConverter()
    //    {
    //        var itemType = typeof(TItem);
    //        if (itemType.IsInterface)
    //        {
    //            var discriminatorAttribute = (PolymorphicDiscriminatorAttribute)Attribute.GetCustomAttribute(itemType, typeof(PolymorphicDiscriminatorAttribute));
    //            if (discriminatorAttribute != null)
    //            {
    //                PolymorphicDiscriminator = discriminatorAttribute.PropertyName;
    //                PolymorphicDiscriminatorIsArray = discriminatorAttribute.IsArray;
    //            }
    //            var implementedTypes = Assembly.GetAssembly(itemType).GetTypes().Where(y => itemType.IsAssignableFrom(y) && !y.IsInterface);
    //            foreach (var implementedType in implementedTypes)
    //            {
    //                var jsonTypeAttribute = (NewtonsoftJsonTypeAttribute)Attribute.GetCustomAttribute(implementedType, typeof(NewtonsoftJsonTypeAttribute));

    //                KeyTypeLookup.Add(jsonTypeAttribute.Value, jsonTypeAttribute.Type);
    //            }
    //        }
    //    }

    //    public ReversibleLookup<string, Type> KeyTypeLookup = new ReversibleLookup<string, Type>();

    //    public override bool CanConvert(Type typeToConvert)
    //        => typeof(TList).IsAssignableFrom(typeToConvert);

    //    public override TList ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {

    //        // Helper function for validating where you are in the JSON    
    //        JToken token = JToken.Load(reader);
    //        if (token.Type == JTokenType.Array)
    //        {

    //        }
    //        var isArray = reader.TokenType == JsonTokenType.StartArray;
    //        if (isArray)
    //        {
    //            reader.Read();
    //        }

    //        // Advance to the first object after the StartArray token. This should be either a StartObject token, or the EndArray token. Anything else is invalid.
    //        var results = new TList();
    //        while (reader.TokenType == JsonTokenType.StartObject)
    //        { // Start of 'wrapper' object
    //            using var jsonDoc = JsonDocument.ParseValue(ref reader);
    //            var typeProperty = jsonDoc.RootElement.GetProperty(PolymorphicDiscriminator);
    //            string typeString;
    //            if (typeProperty.ValueKind == JsonValueKind.Array)
    //            {
    //                typeString = String.Join(',', typeProperty.EnumerateArray().ToList());
    //            }
    //            else
    //            {
    //                typeString = jsonDoc.RootElement.GetProperty("type").GetString();
    //            }


    //            Type type = null;
    //            foreach (var key in KeyTypeLookup.Keys)
    //            {
    //                if (typeString.Contains(key))
    //                {
    //                    type = KeyTypeLookup[key];
    //                    break;
    //                }
    //            }
    //            var item = (TItem)JsonSerializer.Deserialize(jsonDoc.RootElement.GetRawText(), type, options);
    //            results.Add(item);

    //            //reader.Read(); // Move past end of item object
    //            //reader.Read(); // Move past end of 'wrapper' object
    //        }

    //        if (isArray)
    //            validateToken(reader, JsonTokenType.EndArray);

    //        return results;
    //    }

    //    public override void Write(Utf8JsonWriter writer, TList items, JsonSerializerOptions options)
    //    {
    //        if (items.Count > 1)
    //            writer.WriteStartArray();

    //        foreach (var item in items)
    //        {

    //            var itemType = item.GetType();

    //            if (KeyTypeLookup.ReverseLookup.TryGetValue(itemType, out var typeKey))
    //            {
    //                JsonSerializer.Serialize(writer, item, itemType, options);
    //            }
    //            else
    //            {
    //                throw new JsonException($"Unknown type '{itemType.FullName}' found");
    //            }
    //        }

    //        if (items.Count > 1)
    //            writer.WriteEndArray();
    //    }
    //}
}
