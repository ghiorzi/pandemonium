using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is in uppercase, otherwise returns false
        /// </summary> 
        public static bool Upper(this char @this) => Char.IsUpper(@this);
    }
}