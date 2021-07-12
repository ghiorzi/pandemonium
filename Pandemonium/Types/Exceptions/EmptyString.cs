using System;

namespace Pandemonium.Types
{
    public sealed class EmptyStringException : Exception
    {
        internal EmptyStringException() : base("NonEmptyString has failed to result a value") { }
    }
}