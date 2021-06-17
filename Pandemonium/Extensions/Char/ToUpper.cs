using System;

namespace Pandemonium
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts the value of a Unicode character to its uppercase equivalent
        /// </summary> 
        public static char ToUpper(this char self) 
            => char.ToUpper(self);
    }
}