using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not a number, otherwise returns false
        /// </summary> 
        public static bool NotNumber(this char @this) 
            => !Char.IsNumber(@this);
    }
}