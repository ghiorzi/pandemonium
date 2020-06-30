using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not a punctuation, otherwise returns false
        /// </summary> 
        public static bool NotPunctuation(this char @this) => !Char.IsPunctuation(@this);
    }
}