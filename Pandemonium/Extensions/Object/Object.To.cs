using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Casts value to T type
        /// </summary>
        public static T To<T>(this object @this)
        {
            if (@this != null)
            {
                Type target = typeof(T);

                if (@this.GetType() == target)
                    return (T)@this;
            }

            return (T)@this;
        }
    }
}