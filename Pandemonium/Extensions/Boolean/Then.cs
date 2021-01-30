using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It runs the action if value is true
        /// </summary>
        public static bool Then(this bool @this, Action action)
        {
            if (@this)
                action();

            return @this;
        }

        /// <summary>
        /// It runs the function if value is true
        /// </summary>
        public static T Then<T>(this bool @this, Func<T> function)
        {
            if (@this)
                return function();

            return default;
        }
    }
}