using System;

namespace Pandemonium.Types
{
    public sealed class FailableException : Exception
    {
        internal FailableException() : base("Failable has failed to result a value") { }
    }
}