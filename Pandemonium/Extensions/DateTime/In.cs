using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static bool In(this DateTime self, params DateTime[] values)
            => Array.IndexOf(values, self) != -1; 
    }
}