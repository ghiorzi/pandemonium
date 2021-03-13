using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static string ToDescriptionString(this object @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDescriptionString(@this, new StringBuilder()).ToString();
        }

        private static StringBuilder ToDescriptionString(object @this, StringBuilder stringBuilder)
        {
            if (@this == null)
                return stringBuilder;

            Type objType = @this.GetType();
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in properties)
            {
                object @value = property.GetValue(@this);
                if (property.PropertyType.ToString() == @value.ToString())
                    stringBuilder.AppendLine($"{property.Name}: {@value}");
                else
                    stringBuilder.AppendLine($"{property.Name}: {@value} [{property.PropertyType}]");
            }
            return stringBuilder;
        }
    }
}