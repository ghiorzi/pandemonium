using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts the value of a Unicode character to its lowercase equivalent
        /// </summary> 
        public static char ToLower(this char self) 
            => char.ToLower(self);
    }
}