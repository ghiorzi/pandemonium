using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Extensions
    {
        private const sbyte DECEMBER = 12;

        public static DateTime December(this int self, int year) 
            => new (year, DECEMBER, self);
        
        public static DateTime December(this int self, int year, Calendar calendar) 
            => new (year, DECEMBER, self, calendar);

        public static DateTime December(this int self, int year, int hour, int minute, int second) 
            => new (year, DECEMBER, self, hour, minute, second);

        public static DateTime December(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, DECEMBER, self, hour, minute, second, kind);

        public static DateTime December(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, DECEMBER, self, hour, minute, second, calendar);

        public static DateTime December(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, DECEMBER, self, hour, minute, second, millisecond);

        public static DateTime December(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, DECEMBER, self, hour, minute, second, millisecond, kind);
    }
}