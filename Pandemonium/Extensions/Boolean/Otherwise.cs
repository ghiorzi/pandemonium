using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It runs the action when the value is false
        /// </summary>
        public static Nothing Otherwise(this bool self, Action action)
        {
            if (!self)
                action();
            
            return Nothing.Of();
        }

        /// <summary>
        /// It runs the function when the value is false
        /// </summary>
        public static T Otherwise<T>(this bool self, Func<T> function)
        {
            if (!self)
                return function();

            return default;
        }
    }
}