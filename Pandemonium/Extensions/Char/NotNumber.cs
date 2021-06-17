using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a number
        /// </summary> 
        public static bool NotNumber(this char self) 
            => char.IsNumber(self) is false;
    }
}