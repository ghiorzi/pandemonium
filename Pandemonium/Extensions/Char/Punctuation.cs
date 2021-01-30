using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a punctuation, otherwise returns false
        /// </summary> 
        public static bool Punctuation(this char @this) 
            => Char.IsPunctuation(@this);
    }
}