using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// Indicates whether the specified Unicode character is categorized as a number
        /// </summary> 
        public static bool Number(this char self) 
            => char.IsNumber(self);
    }
}