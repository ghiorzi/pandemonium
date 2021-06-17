using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as white space
        /// </summary> 
        public static bool NotWhitespace(this char self) 
            => char.IsWhiteSpace(self) is false;
    }
}