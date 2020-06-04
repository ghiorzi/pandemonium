using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Runs the action if value is true
        /// </summary>
        public static bool Then(this bool @this, Action action)
        {
            if (@this)
                action();

            return @this;
        }

        /// <summary>
        /// Runs the function if value is true
        /// </summary>
        public static T Then<T>(this bool @this, Func<T> function)
        {
            if (@this)
                return function();

            return default;
        }
    }
}