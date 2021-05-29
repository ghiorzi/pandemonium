using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It casts value to T
        /// </summary>
        public static T To<T>(this object self)
        {
            if (self != null)
            {
                Type target = typeof(T);

                if (self.GetType() == target)
                    return (T)self;
            }

            return (T)self;
        }
    }
}