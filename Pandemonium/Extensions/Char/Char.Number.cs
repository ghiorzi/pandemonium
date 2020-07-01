using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a number, otherwise returns false
        /// </summary> 
        public static bool Number(this char @this) => Char.IsNumber(@this);
    }
}