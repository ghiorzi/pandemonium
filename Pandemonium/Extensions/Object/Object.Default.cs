using System.Collections.Generic;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is default, otherwise returns false
        /// </summary>
        public static bool Default<T>(this T @this) 
            => EqualityComparer<T>.Default.Equals(@this, default(T));
    }
}