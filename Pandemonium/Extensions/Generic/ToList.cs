using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static List<T> ToList<T>(this T self) 
            => new() { self };
    }
}