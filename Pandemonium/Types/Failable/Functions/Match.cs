
using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Nothing Match(Action<T> success, Action<Exception> failure)
        {
            var self = this;

            Succeeded
                .Do(() => success(self._value))
                .Otherwise(() => failure(self._error));

            return Nothing.Of();
        }

        public TResult Match<TResult>(Func<T, TResult> success, Func<Exception, TResult> failure)
            => Succeeded
                ? success(_value) 
                : failure(_error);
    }
}