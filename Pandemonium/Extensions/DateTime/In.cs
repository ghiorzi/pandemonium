using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool In(this DateTime self, params DateTime[] values)
            => Array.IndexOf(values, self) != -1; 
    }
}