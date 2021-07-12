using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as white space
        /// </summary> 
        public static bool Whitespace(this char self) 
            => char.IsWhiteSpace(self);
    }
}