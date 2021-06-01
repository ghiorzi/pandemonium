using System;

namespace Pandemonium.Types
{
    public sealed class DoException : Exception
    {
        internal DoException() : base("Do has failed to result a value") { }
    }
}