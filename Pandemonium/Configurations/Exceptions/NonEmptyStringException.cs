using System;

namespace Pandemonium.Configurations
{
    public class NonEmptyStringException : Exception
    {
        internal NonEmptyStringException()
            : base("NonEmptyString must have a value. It cannot be null or empty")
        {
        }
    }
}