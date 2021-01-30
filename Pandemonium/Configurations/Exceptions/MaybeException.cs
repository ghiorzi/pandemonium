using System;

namespace Pandemonium.Configurations
{
    public class MaybeException : Exception
    {
        internal MaybeException()
            : base("Maybe must have a value")
        {
        }
    }
}