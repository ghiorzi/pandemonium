using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not in uppercase, otherwise returns false
        /// </summary> 
        public static bool NotUpper(this char @this) 
            => !Char.IsUpper(@this);
    }
}