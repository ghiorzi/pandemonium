using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not default, otherwise returns false
        /// </summary>
        public static bool NotDefault<T>(this T self) 
            => !EqualityComparer<T>.Default.Equals(self, default);
    }
}