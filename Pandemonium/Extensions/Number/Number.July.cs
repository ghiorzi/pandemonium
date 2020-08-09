using System;
using System.Globalization;

namespace Pandemonium
{
    public static partial class Methods
    {
        private const sbyte JULY = 7;

        public static DateTime July(this int @this, int year) 
            => new DateTime(year, JULY, @this);
        
        public static DateTime July(this int @this, int year, Calendar calendar) 
            => new DateTime(year, JULY, @this, calendar);

        public static DateTime July(this int @this, int year, int hour, int minute, int second) 
            => new DateTime(year, JULY, @this, hour, minute, second);

        public static DateTime July(this int @this, int year, int hour, int minute, int second, DateTimeKind kind) 
            => new DateTime(year, JULY, @this, hour, minute, second, kind);

        public static DateTime July(this int @this, int year, int hour, int minute, int second, Calendar calendar) 
            => new DateTime(year, JULY, @this, hour, minute, second, calendar);

        public static DateTime July(this int @this, int year, int hour, int minute, int second, int millisecond) 
            => new DateTime(year, JULY, @this, hour, minute, second, millisecond);

        public static DateTime July(this int @this, int year, int hour, int minute, int second, int millisecond, DateTimeKind kind) 
            => new DateTime(year, JULY, @this, hour, minute, second, millisecond, kind);
    }
}