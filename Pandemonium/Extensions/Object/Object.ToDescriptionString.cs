using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Linq;

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

            if (objType.ToString() == @this.ToString())
                stringBuilder.AppendLine(string.Format("[{0}]:", objType));
            else
                stringBuilder.AppendLine(string.Format("[{0}]: {1}", objType, @this));

            var properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                .Where(p => p.GetIndexParameters().Length == 0);

            foreach (PropertyInfo property in properties)
            {
                object @value = property.GetValue(@this);

                if (@value.Null())
                    stringBuilder.AppendLine(string.Format("    {0}: null [{1}]", property.Name, property.PropertyType));
                else if (property.PropertyType.ToString() == @value.ToString())
                    stringBuilder.AppendLine(string.Format("    {0}: {1}", property.Name, @value));
                else
                    stringBuilder.AppendLine(string.Format("    {0}: {1} [{2}]", property.Name, @value, property.PropertyType));
            }
            return stringBuilder;
        }
    }
}