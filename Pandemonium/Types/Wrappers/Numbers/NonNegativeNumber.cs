using System;

namespace Pandemonium.Types
{
    public sealed class NonNegativeNumber
    {
        public static Failable<sbyte> From(sbyte value)
            => From(value, new NegativeNumberException());

        public static Failable<sbyte> From(sbyte value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<short> From(short value)
            => From(value, new NegativeNumberException());

        public static Failable<short> From(short value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<int> From(int value)
            => From(value, new NegativeNumberException());

        public static Failable<int> From(int value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<long> From(long value)
            => From(value, new NegativeNumberException());

        public static Failable<long> From(long value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<float> From(float value)
            => From(value, new NegativeNumberException());

        public static Failable<float> From(float value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<double> From(double value)
            => From(value, new NegativeNumberException());

        public static Failable<double> From(double value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }

        public static Failable<decimal> From(decimal value)
            => From(value, new NegativeNumberException());

        public static Failable<decimal> From(decimal value, Exception error)
        {
            if (value.Negative())
                return error;

            return value;
        }
    }
}