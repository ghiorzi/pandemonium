using System;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It runs the action when the value is false
        /// </summary>
        public static void Otherwise(this bool @this, Action action)
        {
            if (!@this)
                action();
        }

        /// <summary>
        /// It runs the function when the value is false
        /// </summary>
        public static T Otherwise<T>(this bool @this, Func<T> function)
        {
            if (!@this)
                return function();

            return default;
        }
    }
}