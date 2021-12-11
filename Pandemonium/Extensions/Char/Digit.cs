using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a decimal digit
        /// </summary>
        public static bool Digit(this char self) 
            => char.IsDigit(self);
    }
}