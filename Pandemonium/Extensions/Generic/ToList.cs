using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static List<T> ToList<T>(this T self) 
            => new() { self };
    }
}