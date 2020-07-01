using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not whitespace, otherwise returns false
        /// </summary> 
        public static bool NotWhitespace(this char @this) => !Char.IsWhiteSpace(@this);
    }
}