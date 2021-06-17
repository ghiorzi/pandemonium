using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static bool Do(this bool self, Action action)
        {
            if (self)
                action();

            return self;
        }
        public static Maybe<T> Do<T>(this bool self, Func<T> function)
        {
            if (self)
                return function();

            return default;
        }
    }
}