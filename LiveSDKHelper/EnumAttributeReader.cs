using System;

namespace LiveSDKHelper
{
    internal static class EnumAttributeReader
    {
        internal static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var attributes = fieldInfo == null ? null : fieldInfo.GetCustomAttributes(typeof(T), false);

            if (attributes == null || attributes.Length == 0) { return null; }

            return attributes[0] as T;
        }
    }
}
