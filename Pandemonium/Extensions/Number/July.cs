using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte JULY = 7;

        public static DateTime July(this int self, int year) 
            => new (year, JULY, self);
        
        public static DateTime July(this int self, int year, Calendar calendar) 
            => new (year, JULY, self, calendar);

        public static DateTime July(this int self, int year, int hour, int minute, int second) 
            => new (year, JULY, self, hour, minute, second);

        public static DateTime July(this int self, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new (year, JULY, self, hour, minute, second, kind);

        public static DateTime July(this int self, int year, int hour, int minute, int second, Calendar calendar) 
            => new (year, JULY, self, hour, minute, second, calendar);

        public static DateTime July(this int self, int year, int hour, int minute, int second, int millisecond) 
            => new (year, JULY, self, hour, minute, second, millisecond);

        public static DateTime July(this int self, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new (year, JULY, self, hour, minute, second, millisecond, kind);
    }
}