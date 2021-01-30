using System;

namespace Pandemonium.Configurations
{
    public class Exceptions
    {
        public Exception NonEmptyStringException { get; }
        public Exception NonNegativeNumberException { get; }
        public Exception MaybeException { get; }

        internal Exceptions()
        {
            NonEmptyStringException = new NonEmptyStringException();
            NonNegativeNumberException = new NonNegativeNumberException();
            MaybeException = new MaybeException();
        }

        public Exceptions(
            Exception nonEmptyStringException = null, 
            Exception nonNegativeNumberException= null,
            Exception maybeException= null)
        {
            NonEmptyStringException = nonEmptyStringException ?? new NonEmptyStringException();
            NonNegativeNumberException = nonNegativeNumberException ?? new NonNegativeNumberException();
            MaybeException = maybeException ?? new MaybeException();
        }
    }
}