using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Remove(this string @this, Func<char, bool> predicate)
        {
            char[] value = @this.ToCharArray();

            return new string(value.Where(x => !predicate(x)).ToArray());
        }
    }
}