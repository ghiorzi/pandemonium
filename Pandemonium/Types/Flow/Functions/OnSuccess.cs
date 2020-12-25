using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        public Nothing OnSuccess(Action action)
        {
            if (Succeeded)
                action();

            return Nothing.Of();
        }

        public Nothing OnSuccess(Action<T> action)
        {
            if (Succeeded)
                action(_value);

            return Nothing.Of();
        }
    }
}