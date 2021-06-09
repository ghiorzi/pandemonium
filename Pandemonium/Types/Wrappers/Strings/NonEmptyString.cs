using System;

namespace Pandemonium.Types
{
    public sealed class NonEmptyString
    {
        public static Failable<string> From(string value)
            => From(value, new EmptyStringException());

        public static Failable<string> From(string value, Exception error)
        {
            if(value.Any())
                return error;
            
            return value;
        }
    }
}