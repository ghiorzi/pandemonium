using System;

namespace Pandemonium.Types
{
    public sealed class EnsureException : Exception
    {
        internal EnsureException() : base("Ensure has failed to result a value") { }
    }
}