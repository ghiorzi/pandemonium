using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not whitespace, otherwise returns false
        /// </summary> 
        public static bool NotWhitespace(this char self) 
            => !Char.IsWhiteSpace(self);
    }
}