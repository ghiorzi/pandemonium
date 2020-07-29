using System.Collections.Generic;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not default, otherwise returns false
        /// </summary>
        public static bool NotDefault<T>(this T @this) 
            => !EqualityComparer<T>.Default.Equals(@this, default(T));
    }
}