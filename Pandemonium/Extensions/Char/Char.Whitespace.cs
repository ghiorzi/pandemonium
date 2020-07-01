using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a whitespace, otherwise returns false
        /// </summary> 
        public static bool Whitespace(this char @this) => Char.IsWhiteSpace(@this);
    }
}