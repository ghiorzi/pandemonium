using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        /// <summary>
        /// It runs the action if value is true
        /// </summary>
        public static bool Then(this bool self, Action action)
        {
            if (self)
                action();

            return self;
        }

        /// <summary>
        /// It runs the function if value is true
        /// </summary>
        public static T Then<T>(this bool self, Func<T> function)
        {
            if (self)
                return function();

            return default;
        }
    }
}