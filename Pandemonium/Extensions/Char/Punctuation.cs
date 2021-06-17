using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a punctuation mark
        /// </summary> 
        public static bool Punctuation(this char self) 
            => char.IsPunctuation(self);
    }
}