using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool NotContains(this string self, string value) 
            => !self.Contains(value);
        public static bool NotContains(this string self, string value, StringComparison comparison)
            => !self.Contains(comparison, value);

        public static bool NotContains(this string self, params string[] values) 
            => !self.Contains(values);
        
        public static bool NotContains(this string self, StringComparison comparison, params string[] values)
            => !self.Contains(comparison, values);
    }
}