using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a letter, otherwise returns false
        /// </summary> 
        public static Boolean Letter(this Char @this) => Char.IsLetter(@this);
    }
}