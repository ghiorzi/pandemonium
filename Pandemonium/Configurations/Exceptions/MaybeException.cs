using System;

namespace Pandemonium.Configurations
{
    public class MaybeException : Exception
    {
        internal MaybeException()
            : base("Maybe does not have a value")
        {
        }
    }
}