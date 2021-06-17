using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Extensions
    {
        private const sbyte MAY = 5;

        public static DateTime May(this int self, int year) 
            => new (year, MAY, self);
        
        public static DateTime May(this int self, int year, Calendar calendar) 
            => new (year, MAY, self, calendar);

        public static DateTime May(this int self, int year, int hour, int minute, int second) 
            => new (year, MAY, self, hour, minute, second);

        public static DateTime May(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, MAY, self, hour, minute, second, kind);

        public static DateTime May(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, MAY, self, hour, minute, second, calendar);

        public static DateTime May(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, MAY, self, hour, minute, second, millisecond);

        public static DateTime May(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, MAY, self, hour, minute, second, millisecond, kind);
    }
}