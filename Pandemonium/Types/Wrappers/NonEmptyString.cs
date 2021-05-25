using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public class NonEmptyString
    {
        public static Failable<string> From(string value)
        {
            if(value.Empty())
                return Configuration.Exceptions.NonEmptyStringException;
            
            return value;
        }
    }
}