using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns true if value is a separator, otherwise returns false
        /// </summary> 
        public static bool Separator(this char @this) 
            => Char.IsSeparator(@this);
    }
}