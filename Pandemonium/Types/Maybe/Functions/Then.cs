using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        /// <summary>
        /// It allows to start a flow
        /// </summary>
        /// <param name="function">Function that will be invoked if having a value</param>
        /// <param name="error">Value that will be used if not having a value</param>
        public Flow<TFlow, Exception> Then<TFlow>(Func<T, Flow<TFlow, Exception>> function)
        {
            if (HasNoValue)
                return Flow.Of<TFlow, Exception>(Configuration.Exceptions.MaybeException);

            return function(_value);
        }

        /// <summary>
        /// It allows to start a flow
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