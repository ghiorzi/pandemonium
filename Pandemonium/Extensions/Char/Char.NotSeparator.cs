using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns true if value is not a separator, otherwise returns false
        /// </summary> 
        public static bool NotSeparator(this char @this) => !Char.IsSeparator(@this);
    }
}