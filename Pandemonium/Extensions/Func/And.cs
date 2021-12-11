using System;

namespace Pandemonium
{
    public static partial class Functions
    {
        public static Func<TSource, bool> And<TSource>(this Func<TSource, bool> self, params Func<TSource, bool>[] functions) 
        {
            return (TSource value) => 
            {
                bool result = self(value);

                foreach (var function in functions)
                    result = result && function(value);
                    
                return result;
            };
        }
    }
}