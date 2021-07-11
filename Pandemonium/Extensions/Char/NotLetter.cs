using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a Unicode letter
        /// </summary> 
        public static bool NotLetter(this char self) 
            => char.IsLetter(self) is false;
    }
}