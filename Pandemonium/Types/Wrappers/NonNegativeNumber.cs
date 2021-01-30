using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public class NonNegativeNumber
    {
        public static Flow<sbyte, Exception> Of(sbyte value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<short, Exception> Of(short value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<int, Exception> Of(int value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<long, Exception> Of(long value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<float, Exception> Of(float value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<double, Exception> Of(double value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Flow<decimal, Exception> Of(decimal value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }
    }
}