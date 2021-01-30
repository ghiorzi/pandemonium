using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Functions
    {
        private const sbyte JUNE = 6;

        public static DateTime June(this int @this, int year) 
            => new DateTime(year, JUNE, @this);
        
        public static DateTime June(this int @this, int year, Calendar calendar) 
            => new DateTime(year, JUNE, @this, calendar);

        public static DateTime June(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, JUNE, @this, hour, minute, second);

        public static DateTime June(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, JUNE, @this, hour, minute, second, kind);

        public static DateTime June(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, JUNE, @this, hour, minute, second, calendar);

        public static DateTime June(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, JUNE, @this, hour, minute, second, millisecond);

        public static DateTime June(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, JUNE, @this, hour, minute, second, millisecond, kind);
    }
}