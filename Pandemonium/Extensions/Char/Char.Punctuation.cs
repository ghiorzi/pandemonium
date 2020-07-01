using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a punctuation, otherwise returns false
        /// </summary> 
        public static bool Punctuation(this char @this) => Char.IsPunctuation(@this);
    }
}