using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte OCTOBER = 10;

        public static DateTime October(this int @this, int year) 
            => new DateTime(year, OCTOBER, @this);
        
        public static DateTime October(this int @this, int year, Calendar calendar) 
            => new DateTime(year, OCTOBER, @this, calendar);

        public static DateTime October(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, OCTOBER, @this, hour, minute, second);

        public static DateTime October(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, OCTOBER, @this, hour, minute, second, kind);

        public static DateTime October(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, OCTOBER, @this, hour, minute, second, calendar);

        public static DateTime October(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, OCTOBER, @this, hour, minute, second, millisecond);

        public static DateTime October(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, OCTOBER, @this, hour, minute, second, millisecond, kind);
    }
}