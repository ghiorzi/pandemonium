using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not in uppercase, otherwise returns false
        /// </summary> 
        public static bool NotUpper(this char @this) => !Char.IsUpper(@this);
    }
}