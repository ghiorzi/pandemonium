using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a Unicode letter.
        /// </summary> 
        public static bool Letter(this char self) 
            => char.IsLetter(self);
    }
}