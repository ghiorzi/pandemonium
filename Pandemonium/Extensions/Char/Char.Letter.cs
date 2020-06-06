using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a letter, otherwise returns false
        /// </summary> 
        public static bool Letter(this char @this) => Char.IsLetter(@this);
    }
}