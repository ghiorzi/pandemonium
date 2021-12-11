using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte NOVEMBER = 11;

        public static DateTime November(this int self, int year) 
            => new (year, NOVEMBER, self);
        
        public static DateTime November(this int self, int year, Calendar calendar) 
            => new (year, NOVEMBER, self, calendar);

        public static DateTime November(this int self, int year, int hour, int minute, int second) 
            => new (year, NOVEMBER, self, hour, minute, second);

        public static DateTime November(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, NOVEMBER, self, hour, minute, second, kind);

        public static DateTime November(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, NOVEMBER, self, hour, minute, second, calendar);

        public static DateTime November(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, NOVEMBER, self, hour, minute, second, millisecond);

        public static DateTime November(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, NOVEMBER, self, hour, minute, second, millisecond, kind);
    }
}