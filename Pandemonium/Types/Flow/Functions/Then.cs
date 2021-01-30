using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        /// <summary>
        /// It allows railway programming
        /// </summary>
        /// <param name="function">Function that will be invoked if succeeded</param>
        public Flow<TFlow, TError> Then<TFlow>(Func<T, Flow<TFlow, TError>> function)
        {
            if (Failed)
                return Flow.Of<TFlow, TError>(_error);

            return function(_value);
        }
    }
}