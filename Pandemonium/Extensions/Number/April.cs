using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Extensions
    {
        private const sbyte APRIL = 4;

        public static DateTime April(this int self, int year) 
            => new (year, APRIL, self);
        
        public static DateTime April(this int self, int year, Calendar calendar) 
            => new (year, APRIL, self, calendar);

        public static DateTime April(this int self, int year, int hour, int minute, int second) 
            => new (year, APRIL, self, hour, minute, second);

        public static DateTime April(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, APRIL, self, hour, minute, second, kind);

        public static DateTime April(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, APRIL, self, hour, minute, second, calendar);

        public static DateTime April(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, APRIL, self, hour, minute, second, millisecond);

        public static DateTime April(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, APRIL, self, hour, minute, second, millisecond, kind);
    }
}