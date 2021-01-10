using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is in uppercase, otherwise returns false
        /// </summary> 
        public static bool Upper(this char @this) 
            => Char.IsUpper(@this);
    }
}