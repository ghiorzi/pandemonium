using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a Unicode letter or as a decimal digit
        /// </summary> 
        public static bool LetterOrDigit(this char self) 
            => char.IsLetter(self) || char.IsDigit(self);
    }
}