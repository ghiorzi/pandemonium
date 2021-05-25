using System;

namespace Pandemonium.Types
{
    public partial struct Failable<T>
    {
        /// <summary>
        ///  It runs regardless of whether it's success or failure
        /// </summary>
        public TResult Finally<TResult>(Func<Failable<T>, TResult> function)
            => function(this);
    }
}