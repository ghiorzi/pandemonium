using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not a letter, otherwise returns false
        /// </summary> 
        public static bool NotLetter(this char @this) => !Char.IsLetter(@this);
    }
}