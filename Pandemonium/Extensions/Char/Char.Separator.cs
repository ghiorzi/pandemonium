using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is a separator, otherwise returns false
        /// </summary> 
        public static bool Separator(this char @this) => Char.IsSeparator(@this);
    }
}