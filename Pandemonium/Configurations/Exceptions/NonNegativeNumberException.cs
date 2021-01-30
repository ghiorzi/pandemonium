using System;

namespace Pandemonium.Configurations
{
    public class NonNegativeNumberException : Exception
    {
        internal NonNegativeNumberException()
            : base("NonNegativeNumber must have a positive value")
        {
        }
    }
}