using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte OCTOBER = 10;

        public static DateTime October(this int self, int year) 
            => new (year, OCTOBER, self);
        
        public static DateTime October(this int self, int year, Calendar calendar) 
            => new (year, OCTOBER, self, calendar);

        public static DateTime October(this int self, int year, int hour, int minute, int second) 
            => new (year, OCTOBER, self, hour, minute, second);

        public static DateTime October(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, OCTOBER, self, hour, minute, second, kind);

        public static DateTime October(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, OCTOBER, self, hour, minute, second, calendar);

        public static DateTime October(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, OCTOBER, self, hour, minute, second, millisecond);

        public static DateTime October(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, OCTOBER, self, hour, minute, second, millisecond, kind);
    }
}