using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It returns a non memory reference copy of @this. <b>The type must be serializables</b>.
        /// </summary>
        public static IEnumerable<T> Copy<T>(this IEnumerable<T> @this)
            => @this.Clone();
    }
}
