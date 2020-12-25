
using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        /// <summary>
        /// It allows to apply actions for success and failure scenarios without having conditionals
        /// </summary>
        /// <param name="onSuccess">Action that will be invoked if succeeded</param>
        /// <param name="onFailure">Action that will be invoked if failed</param>
        public Nothing Match(Action<T> onSuccess, Action<TError> onFailure)
        {
            var self = this;

            Succeeded
                .Then(() => onSuccess(self._value))
                .Otherwise(() => onFailure(self._error));

            return Nothing.Of();
        }

        /// <summary>
        /// It allows to apply functions for success and failure scenarios without having conditionals
        /// </summary>
        /// <param name="onSuccess">Function that will be invoked if succeeded</param>
        /// <param name="onFailure">Function that will be invoked if failed</param>
        public TFlow Match<TFlow>(Func<T, TFlow> onSuccess, Func<TError, TFlow> onFailure)
            => Succeeded ? onSuccess(_value) : onFailure(_error);
    }
}