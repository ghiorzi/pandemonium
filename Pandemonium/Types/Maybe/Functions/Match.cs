using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        /// <summary>
        /// It allows to apply functions for some and none scenarios without having conditionals
        /// </summary>
        /// <param name="onSome">Function that will be invoked when having a value</param>
        /// <param name="onNone">Function that will be invoked when not having a value</param>
        public TFlow Match<TFlow>(Func<T, TFlow> onSome, Func<TFlow> onNone)
            => HasValue ? onSome(_value) : onNone();

        /// <summary>
        /// It allows to apply actions for some and none scenarios without having conditionals
        /// </summary>
        /// <param name="onSome">Action that will be invoked when having a value</param>
        /// <param name="onNone">Action that will be invoked when not having a value</param>
        public Nothing Match(Action<T> onSome, Action onNone)
        {
            var self = this;

            HasValue
                .Then(() => onSome(self._value))
                .Otherwise(() => onNone());
            
            return Nothing.Of();
        }
    }
}