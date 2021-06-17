using System;
using Pandemonium.Types;

namespace Pandemonium
{
    public static partial class Extensions
    {
        public static Failable<sbyte> Where(this sbyte self, Func<sbyte, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<sbyte> Where(this sbyte self, Func<sbyte, bool> predicate, Exception error)
            => Where<sbyte>(self, predicate, error);
        
        public static Failable<byte> Where(this byte self, Func<byte, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<byte> Where(this byte self, Func<byte, bool> predicate, Exception error)
            => Where<byte>(self, predicate, error);

        public static Failable<short> Where(this short self, Func<short, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<short> Where(this short self, Func<short, bool> predicate, Exception error)
            => Where<short>(self, predicate, error);

        public static Failable<ushort> Where(this ushort self, Func<ushort, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<ushort> Where(this ushort self, Func<ushort, bool> predicate, Exception error)
            => Where<ushort>(self, predicate, error);

        public static Failable<int> Where(this int self, Func<int, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<int> Where(this int self, Func<int, bool> predicate, Exception error)
            => Where<int>(self, predicate, error);
        
        public static Failable<uint> Where(this uint self, Func<uint, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<uint> Where(this uint self, Func<uint, bool> predicate, Exception error)
            => Where<uint>(self, predicate, error);
        
        public static Failable<long> Where(this long self, Func<long, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<long> Where(this long self, Func<long, bool> predicate, Exception error)
            => Where<long>(self, predicate, error);
        
        public static Failable<ulong> Where(this ulong self, Func<ulong, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<ulong> Where(this ulong self, Func<ulong, bool> predicate, Exception error)
            => Where<ulong>(self, predicate, error);

        public static Failable<float> Where(this float self, Func<float, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<float> Where(this float self, Func<float, bool> predicate, Exception error)
            => Where<float>(self, predicate, error);
        
        public static Failable<double> Where(this double self, Func<double, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<double> Where(this double self, Func<double, bool> predicate, Exception error)
            => Where<double>(self, predicate, error);
        
        public static Failable<decimal> Where(this decimal self, Func<decimal, bool> predicate)
            => Where(self, predicate, new WhereException());

        public static Failable<decimal> Where(this decimal self, Func<decimal, bool> predicate, Exception error)
            => Where<decimal>(self, predicate, error);

        private static Failable<T> Where<T>(T value, Func<T, bool> predicate, Exception error)
        {
            #pragma warning disable CS8604
            if (predicate(value) is false)
                return Failable.FromException<T>(error);

            return Failable.From(value);
        }
    }
}