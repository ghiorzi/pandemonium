using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if value is a letter OR a digit, otherwise returns false
        /// </summary> 
        public static bool LetterOrDigit(this char @this) 
            => Char.IsLetter(@this) || Char.IsDigit(@this);
    }
}