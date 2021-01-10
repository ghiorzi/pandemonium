using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not in lowercase, otherwise returns false
        /// </summary> 
        public static bool NotLower(this char @this) 
            => !Char.IsLower(@this);
    }
}