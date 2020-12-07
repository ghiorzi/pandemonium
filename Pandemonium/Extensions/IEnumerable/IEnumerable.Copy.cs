using System.Collections.Generic;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// Return a non memory reference copy of enumeration. <b>The type must be serializables</b>.
        /// </summary>
        public static IEnumerable<T> Copy<T>(this IEnumerable<T> @this)
            => @this.Clone();
    }
}
