using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {

        public static Nothing Otherwise(this bool self, Action action)
        {
            if (self is false)
                action();
            
            return Nothing.Of();
        }

        public static T Otherwise<T>(this bool self, Func<T> function)
        {
            if (self is false)
                return function();

            return default;
        }
    }
}