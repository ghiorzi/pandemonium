using System;
using System.Linq;

namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        public static string Where(this string @this, Func<char, bool> predicate)
        {
            char[] value = @this.ToCharArray();

            return new string(value.Where(predicate).ToArray());
        }
    }
}