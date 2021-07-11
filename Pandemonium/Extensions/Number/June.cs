using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte JUNE = 6;

        public static DateTime June(this int self, int year) 
            => new (year, JUNE, self);
        
        public static DateTime June(this int self, int year, Calendar calendar) 
            => new (year, JUNE, self, calendar);

        public static DateTime June(this int self, int year, int hour, int minute, int second) 
            => new (year, JUNE, self, hour, minute, second);

        public static DateTime June(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, JUNE, self, hour, minute, second, kind);

        public static DateTime June(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, JUNE, self, hour, minute, second, calendar);

        public static DateTime June(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, JUNE, self, hour, minute, second, millisecond);

        public static DateTime June(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, JUNE, self, hour, minute, second, millisecond, kind);
    }
}