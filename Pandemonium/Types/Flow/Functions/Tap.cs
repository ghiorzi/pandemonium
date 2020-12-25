using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        /// <summary>
        /// It runs the <paramref name="action"/> if succeeded
        /// </summary>
        /// <param name="action">Action that will be invoked</param>
        public Flow<T, TError> Tap(Action action)
        {
            if(Succeeded)
                action();

            return this;
        }

        /// <summary>
        /// It runs the <paramref name="action"/> if succeeded
        /// </summary>
        /// <param name="action">Action that will be invoked</param>
        public Flow<T, TError> Tap(Action<T> action)
        {
            if(Succeeded)
                action(_value);

            return this;
        }
    }
}