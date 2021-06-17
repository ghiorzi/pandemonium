using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a decimal digit.
        /// </summary> 
        public static bool NotDigit(this char self) 
            => char.IsDigit(self) is false;
    }
}