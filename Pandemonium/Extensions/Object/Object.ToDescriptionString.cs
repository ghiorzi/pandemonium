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

            return ToDescriptionString(@this, new StringBuilder(), 0).ToString();
        }

        private static StringBuilder ToDescriptionString(object @this, StringBuilder stringBuilder, int indentCount)
        {
            if (@this == null)
                return stringBuilder;

            string indentation = new string(' ', indentCount);

            Type objType = @this.GetType();
            PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(@this, null);
                if (value is IEnumerable)
                {
                    var enumeration = value as IEnumerable;
                    foreach (var element in enumeration)
                    {
                        ToDescriptionString(element, stringBuilder, indentCount + 3);
                    }
                }
                else
                {
                    if (property.PropertyType.Assembly == objType.Assembly)
                    {
                        stringBuilder
                            .AppendFormat("{0}{1}:", indentation, property.Name)
                            .AppendLine();

                        ToDescriptionString(value, stringBuilder, indentCount + 2);
                    }
                    else
                    {
                        stringBuilder
                            .AppendFormat("{0}{1}: {2}", indentation, property.Name, value)
                            .AppendLine();
                    }
                }
            }
            return stringBuilder;
        }
    }
}