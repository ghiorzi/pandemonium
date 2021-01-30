using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a whitespace, otherwise returns false
        /// </summary> 
        public static bool Whitespace(this char @this) 
            => Char.IsWhiteSpace(@this);
    }
}