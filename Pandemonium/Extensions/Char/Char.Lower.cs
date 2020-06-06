using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is in lowercase, otherwise returns false
        /// </summary> 
        public static bool Lower(this char @this) => Char.IsLower(@this);
    }
}