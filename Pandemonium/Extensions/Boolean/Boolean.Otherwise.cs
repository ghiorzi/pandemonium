using System;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Runs the action when the value is false
        /// </summary>
        public static void Otherwise(this bool @this, Action action)
        {
            if (!@this)
                action();
        }

        /// <summary>
        /// Runs the function when the value is false
        /// </summary>
        public static T Otherwise<T>(this bool @this, Func<T> function)
        {
            if (!@this)
                return function();

            return default;
        }
    }
}