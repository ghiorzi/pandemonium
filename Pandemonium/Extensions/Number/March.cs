using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte MARCH = 3;

        public static DateTime March(this int self, int year) 
            => new (year, MARCH, self);
        
        public static DateTime March(this int self, int year, Calendar calendar) 
            => new (year, MARCH, self, calendar);

        public static DateTime March(this int self, int year, int hour, int minute, int second) 
            => new (year, MARCH, self, hour, minute, second);

        public static DateTime March(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, MARCH, self, hour, minute, second, kind);

        public static DateTime March(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, MARCH, self, hour, minute, second, calendar);

        public static DateTime March(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, MARCH, self, hour, minute, second, millisecond);

        public static DateTime March(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, MARCH, self, hour, minute, second, millisecond, kind);
    }
}