using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte FEBRUARY = 2;

        public static DateTime February(this int self, int year)
            => new (year, FEBRUARY, self);
        
        public static DateTime February(this int self, int year, Calendar calendar) 
            => new (year, FEBRUARY, self, calendar);

        public static DateTime February(this int self, int year, int hour, int minute, int second) 
            => new (year, FEBRUARY, self, hour, minute, second);

        public static DateTime February(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, FEBRUARY, self, hour, minute, second, kind);

        public static DateTime February(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, FEBRUARY, self, hour, minute, second, calendar);

        public static DateTime February(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, FEBRUARY, self, hour, minute, second, millisecond);

        public static DateTime February(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, FEBRUARY, self, hour, minute, second, millisecond, kind);
    }
}