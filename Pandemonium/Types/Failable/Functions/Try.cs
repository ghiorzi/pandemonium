using System;

namespace Pandemonium.Types
{
    public static partial class Failable
    {
        public static Failable<T> Try<T>(Func<T> function)
        {
            try
            {
                return From(function());
            }
            catch (Exception error)
            {
                return FromException<T>(error);
            }
        }

        public static Failable<TResult> Try<T, TResult>(Func<TResult> function, Func<Exception, TResult> errorHandler)
        {
            try
            {
                return From(function());
            }
            catch (Exception error)
            {
                return From(errorHandler(error));
            }
        }
    }
}