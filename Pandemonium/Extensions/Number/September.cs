using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Extensions
    {
        private const sbyte SEPTEMBER = 9;

        public static DateTime September(this int self, int year) 
            => new (year, SEPTEMBER, self);
        
        public static DateTime September(this int self, int year, Calendar calendar) 
            => new (year, SEPTEMBER, self, calendar);

        public static DateTime September(this int self, int year, int hour, int minute, int second) 
            => new (year, SEPTEMBER, self, hour, minute, second);

        public static DateTime September(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, SEPTEMBER, self, hour, minute, second, kind);

        public static DateTime September(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, SEPTEMBER, self, hour, minute, second, calendar);

        public static DateTime September(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, SEPTEMBER, self, hour, minute, second, millisecond);

        public static DateTime September(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, SEPTEMBER, self, hour, minute, second, millisecond, kind);
    }
}