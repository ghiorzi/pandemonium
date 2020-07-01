using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a digit, otherwise returns false
        /// </summary>
        public static bool Digit(this char @this) => Char.IsDigit(@this);
    }
}