using System;

namespace Pandemonium.Types
{
    public static partial class Flow
    {
        /// <summary>
        ///  It tries to execute the function
        /// </summary>
        public static Flow<T, TException> Try<T, TException>(Func<T> function) where TException: Exception
        {
            try
            {
                return Flow.Of<T, TException>(function());
            }
            catch (TException exception)
            {
                return Flow.Of<T, TException>(exception);
            }
        }

         /// <summary>
        ///  It tries to execute the function with a error handler
        /// </summary>
        public static Flow<T, TError> Try<T, TError>(Func<T> function, Func<Exception, TError> errorHandler)
        {
            try
            {
                return Flow.Of<T, TError>(function());
            }
            catch (Exception exception)
            {
                TError error = errorHandler(exception);

                return Flow.Of<T, TError>(error);
            }
        }
    }
}