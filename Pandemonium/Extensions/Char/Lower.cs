using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a lowercase letter
        /// </summary> 
        public static bool Lower(this char self) 
            => char.IsLower(self);
    }
}