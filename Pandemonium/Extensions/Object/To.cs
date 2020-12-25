using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It casts value to T
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