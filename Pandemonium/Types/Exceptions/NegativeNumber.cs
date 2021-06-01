using System;

namespace Pandemonium.Types
{
    public sealed class NegativeNumberException : Exception
    {
        internal NegativeNumberException() : base("NonNegativeNumber has failed to result a value") { }
    }
}