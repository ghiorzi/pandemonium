using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as an uppercase letter
        /// </summary> 
        public static bool Upper(this char self) 
            => char.IsUpper(self);
    }
}