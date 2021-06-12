
using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Nothing Match(Action<T> success, Action<Exception> failure)
        {
            var self = this;

            Succeeded
                #pragma warning disable CS8604
                .Do(() => success(self._value))
                .Otherwise(() => failure(self._error));

            return Nothing.Of();
        }
    }
}