using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a separator character
        /// </summary> 
        public static bool NotSeparator(this char self) 
            => char.IsSeparator(self) is false;
    }
}