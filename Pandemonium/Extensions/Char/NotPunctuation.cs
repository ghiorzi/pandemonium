using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It returns true if value is not a punctuation, otherwise returns false
        /// </summary> 
        public static bool NotPunctuation(this char @this) 
            => !Char.IsPunctuation(@this);
    }
}