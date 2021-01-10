using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotContains(this string @this, string value) 
            => !@this.Contains(value);
        public static bool NotContains(this string @this, string value, StringComparison comparison)
            => !@this.Contains(comparison, value);

        public static bool NotContains(this string @this, params string[] values) 
            => !@this.Contains(values);
        
        public static bool NotContains(this string @this, StringComparison comparison, params string[] values)
            => !@this.Contains(comparison, values);
    }
}