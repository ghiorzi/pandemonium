using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Where(this string @this, Func<char, bool> predicate)
        {
            char[] value = @this.ToCharArray();

            return new string(value.Where(predicate).ToArray());
        }
    }
}