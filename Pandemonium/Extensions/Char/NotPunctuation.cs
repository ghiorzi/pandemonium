using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is not categorized as a punctuation mark
        /// </summary> 
        public static bool NotPunctuation(this char self) 
            => char.IsPunctuation(self) is false;
    }
}