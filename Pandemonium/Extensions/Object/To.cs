using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static T? To<T>(this object self)
        {
            if (self is not null)
            {
                Type target = typeof(T);

                if (self.GetType() == target)
                    return (T)self;
            }

            return (T?) self;
        }
    }
}