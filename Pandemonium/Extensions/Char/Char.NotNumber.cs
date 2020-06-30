using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not a number, otherwise returns false
        /// </summary> 
        public static bool NotNumber(this char @this) => !Char.IsNumber(@this);
    }
}