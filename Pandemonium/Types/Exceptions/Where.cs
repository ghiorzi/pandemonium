using System;

namespace Pandemonium.Types
{
    public sealed class WhereException : Exception
    {
        internal WhereException() : base("Where has failed to result a value") { }
    }
}