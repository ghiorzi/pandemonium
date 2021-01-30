using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is not a separator, otherwise returns false
        /// </summary> 
        public static bool NotSeparator(this char @this) 
            => !Char.IsSeparator(@this);
    }
}