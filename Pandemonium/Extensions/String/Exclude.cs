using System;
using System.Linq;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static string Exclude(this string self, Func<char, bool> predicate)
        {
            char[] value = self.ToCharArray();

            return new string(value.Exclude(x => predicate(x)).ToArray());
        }
    }
}