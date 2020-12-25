using System;
using System.Collections.Generic;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Methods
    {
        public static Nothing ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (T element in @this) 
                action(element);

            return Nothing.Of();
        }
    }
}