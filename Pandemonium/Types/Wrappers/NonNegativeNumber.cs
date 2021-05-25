using System;
using Pandemonium.Configurations;

namespace Pandemonium.Types
{
    public class NonNegativeNumber
    {
        public static Failable<sbyte> From(sbyte value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<short> From(short value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<int> From(int value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<long> From(long value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<float> From(float value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<double> From(double value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }

        public static Failable<decimal> From(decimal value)
        {
            if(value.Negative())
                return Configuration.Exceptions.NonNegativeNumberException;
            
            return value;
        }
    }
}