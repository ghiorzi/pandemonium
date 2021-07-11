using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte JANUARY = 1;

        public static DateTime January(this int self, int year) 
            => new (year, JANUARY, self);
        
        public static DateTime January(this int self, int year, Calendar calendar) 
            => new (year, JANUARY, self, calendar);

        public static DateTime January(this int self, int year, int hour, int minute, int second) 
            => new (year, JANUARY, self, hour, minute, second);

        public static DateTime January(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, JANUARY, self, hour, minute, second, kind);

        public static DateTime January(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, JANUARY, self, hour, minute, second, calendar);

        public static DateTime January(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, JANUARY, self, hour, minute, second, millisecond);

        public static DateTime January(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, JANUARY, self, hour, minute, second, millisecond, kind);
    }
}