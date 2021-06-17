using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Extensions
    {
        private const sbyte AUGUST = 8;

        public static DateTime August(this int self, int year) 
            => new (year, AUGUST, self);
        
        public static DateTime August(this int self, int year, Calendar calendar) 
            => new (year, AUGUST, self, calendar);

        public static DateTime August(this int self, int year, int hour, int minute, int second) 
            => new (year, AUGUST, self, hour, minute, second);

        public static DateTime August(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, AUGUST, self, hour, minute, second, kind);

        public static DateTime August(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, AUGUST, self, hour, minute, second, calendar);

        public static DateTime August(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, AUGUST, self, hour, minute, second, millisecond);

        public static DateTime August(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, AUGUST, self, hour, minute, second, millisecond, kind);
    }
}