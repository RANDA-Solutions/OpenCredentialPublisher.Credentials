using System;

namespace OpenCredentialPublisher.Credentials.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class NewtonsoftJsonTypeAttribute : Attribute
    {
        public string Value { get; set; }
        public Type Type { get; set; }
        public NewtonsoftJsonTypeAttribute(string value, Type type)
        {
            Value = value;
            Type = type;
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PolymorphicDiscriminatorAttribute : Attribute
    {
        public string PropertyName { get; set; }
        public bool IsArray { get; set; }
        public PolymorphicDiscriminatorAttribute(string propertyName, bool isArray)
        {
            PropertyName = propertyName;
            IsArray = isArray;
        }
    }
}
