using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        ///  Returns true if @this is empty like my heart
        /// </summary>
        public static bool Empty(this string @this) 
            => @this == "" || @this == null;
    }
}