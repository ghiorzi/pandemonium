
using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Nothing Match(Action<T> success, Action<Exception> failure)
        {
            #pragma warning disable CS8604
            if (Succeeded)
                success(Value);
            else
                failure(Error);

            return Nothing.Of();
        }
    }
}