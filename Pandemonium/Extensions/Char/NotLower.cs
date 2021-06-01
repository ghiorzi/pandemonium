using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a lowercase letter
        /// </summary> 
        public static bool NotLower(this char self) 
            => char.IsLower(self) is false;
    }
}