using System;

namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        /// <summary>
        ///  It runs regardless of whether it's success or failure
        /// </summary>
        public TFlow Finally<TFlow>(Func<Flow<T, TError>, TFlow> function)
            => function(this);
    }
}