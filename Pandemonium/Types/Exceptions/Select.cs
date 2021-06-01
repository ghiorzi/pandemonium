using System;

namespace Pandemonium.Types
{
    public sealed class SelectException : Exception
    {
        internal SelectException() : base("Select has failed to result a value") { }
    }
}