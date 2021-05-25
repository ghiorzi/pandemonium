using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public Nothing OnFailure(Action action)
        {
            if (Failed)
                action();

            return Nothing.Of();
        }

        public Nothing OnFailure(Action<Exception> action)
        {
            if (Failed)
                action(_error);

            return Nothing.Of();
        }
    }
}