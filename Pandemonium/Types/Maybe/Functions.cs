using System;

namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        #region Static
        public static Maybe<T> From(T value)
            => new Maybe<T>(value);
        #endregion

        #region Instance

        /// <summary>
        /// It allows to apply functions for some and none scenarios without having conditionals
        /// </summary>
        /// <param name="OnSome">Function that will be invoked when having a value</param>
        /// <param name="OnNone">Function that will be invoked when not having a value</param>
        public TResult Match<TResult>(Func<T, TResult> OnSome, Func<TResult> OnNone)
            => HasValue ? OnSome(_value) : OnNone();

        /// <summary>
        /// It allows to apply actions for some and none scenarios without having conditionals
        /// </summary>
        /// <param name="OnSome">Action that will be invoked when having a value</param>
        /// <param name="OnNone">Action that will be invoked when not having a value</param>
        public void Match(Action<T> OnSome, Action OnNone)
        {
            var self = this;

            HasValue
                .Then(() => OnSome(self._value))
                .Otherwise(() => OnNone());
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
            => _value.Equals(obj);

        public override int GetHashCode()
        {
            if (HasNoValue)
                return 0;

            return _value.GetHashCode();
        }

        public override string ToString()
        {
            if (HasNoValue)
                return "It has no value";

            return _value.ToString();
        }
        #endregion
    }
}