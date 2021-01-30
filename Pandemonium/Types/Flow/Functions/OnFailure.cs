using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        public Nothing OnFailure(Action action)
        {
            if (Failed)
                action();

            return Nothing.Of();
        }

        public Nothing OnFailure(Action<TError> action)
        {
            if (Failed)
                action(_error);

            return Nothing.Of();
        }
    }
}