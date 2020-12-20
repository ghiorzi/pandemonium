using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// It runs the action when the value is false
        /// </summary>
        public static Nothing Otherwise(this bool @this, Action action)
        {
            if (!@this)
                action();
            
            return Nothing.Of();
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