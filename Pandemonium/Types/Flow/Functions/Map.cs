using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        /// <summary>
        /// It maps from <paramref name="T"/> to <paramref name="TFlow"/>  
        /// </summary>
        /// <typeparam name="T">The type of the first parameter of <paramref name="function"/>.</typeparam>
        /// <typeparam name="TFlow">The type of the second parameter of <paramref name="function"/>.</typeparam>
        public Flow<TFlow, TError> Map<TFlow>(Func<T, TFlow> function)
        {
            if (Failed)
                return Flow.Of<TFlow, TError>(_error);

            return Flow.Of<TFlow, TError>(function(_value));
        }
    }
}