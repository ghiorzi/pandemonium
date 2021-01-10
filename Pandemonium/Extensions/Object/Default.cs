using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is default, otherwise returns false
        /// </summary>
        public static bool Default<T>(this T @this) 
            => EqualityComparer<T>.Default.Equals(@this, default(T));
    }
}