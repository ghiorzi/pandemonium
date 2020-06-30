using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not a digit, otherwise returns false
        /// </summary> 
        public static bool NotDigit(this char @this) => !Char.IsDigit(@this);
    }
}