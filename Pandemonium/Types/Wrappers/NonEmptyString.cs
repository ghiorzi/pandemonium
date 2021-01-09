using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public struct NonEmptyString
    {
        public static Flow<string, Exception> Of(string value)
        {
            if(value.Empty())
                return Configuration.Exceptions.NonEmptyStringException;
            
            return value;
        }
    }
}