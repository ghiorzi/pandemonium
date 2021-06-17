using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as an uppercase letter
        /// </summary> 
        public static bool NotUpper(this char self) 
            => char.IsUpper(self) is false;
    }
}