using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Return true if @this is not empty
        /// </summary>
        public static bool NotEmpty(this string @this) => !string.IsNullOrEmpty(@this);
    }
}