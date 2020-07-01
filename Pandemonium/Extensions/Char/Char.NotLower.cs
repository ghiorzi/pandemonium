using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not in lowercase, otherwise returns false
        /// </summary> 
        public static bool NotLower(this char @this) => !Char.IsLower(@this);
    }
}