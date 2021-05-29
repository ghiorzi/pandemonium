using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        public TResult Finally<TResult>(Func<Failable<T>, TResult> function)
            => function(this);
    }
}