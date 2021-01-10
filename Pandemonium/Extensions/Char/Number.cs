using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a number, otherwise returns false
        /// </summary> 
        public static bool Number(this char @this) 
            => Char.IsNumber(@this);
    }
}