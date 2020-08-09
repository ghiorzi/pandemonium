using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Methods
    {
        private const sbyte NOVEMBER = 11;

        public static DateTime November(this int @this, int year) 
            => new DateTime(year, NOVEMBER, @this);
        
        public static DateTime November(this int @this, int year, Calendar calendar) 
            => new DateTime(year, NOVEMBER, @this, calendar);

        public static DateTime November(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, NOVEMBER, @this, hour, minute, second);

        public static DateTime November(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, NOVEMBER, @this, hour, minute, second, kind);

        public static DateTime November(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, NOVEMBER, @this, hour, minute, second, calendar);

        public static DateTime November(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, NOVEMBER, @this, hour, minute, second, millisecond);

        public static DateTime November(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, NOVEMBER, @this, hour, minute, second, millisecond, kind);
    }
}