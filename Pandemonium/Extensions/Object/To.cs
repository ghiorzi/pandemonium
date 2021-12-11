using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        # pragma warning disable CS0168
        public static Maybe<T> To<T>(this object self)
        {
            if (self is not null)
            {
                try {
                    return (T) self;
                } catch (Exception _) {
                    return default;
                }
            }

            return default;
        }
    }
}