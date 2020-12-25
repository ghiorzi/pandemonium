using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        /// <summary>
        /// It allows railway programming
        /// </summary>
        /// <param name="function">Function that will be invoked if having a value</param>
        /// <param name="error">Value that will be used if not having a value</param>
        public Flow<TFlow, TError> Then<TFlow, TError>(Func<T, Flow<TFlow, TError>> function, TError error)
        {
            if (HasNoValue)
                return Flow.Of<TFlow, TError>(error);

            return function(_value);
        }
    }
}