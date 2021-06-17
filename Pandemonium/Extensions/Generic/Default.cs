using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Default<T>(this T self) 
            => EqualityComparer<T>.Default.Equals(self, default);
    }
}