using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a separator character
        /// </summary> 
        public static bool Separator(this char self) 
            => char.IsSeparator(self);
    }
}