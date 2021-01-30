using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not a digit, otherwise returns false
        /// </summary> 
        public static bool NotDigit(this char @this) 
            => !Char.IsDigit(@this);
    }
}