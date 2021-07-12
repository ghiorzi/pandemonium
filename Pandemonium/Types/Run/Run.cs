using System;

namespace Pandemonium.Types
{
    public static class Run
    {     
        public static Runnable<TSource> When<TSource>(Func<TSource, bool> predicate) 
        {
            if (predicate is null)
                throw new ArgumentException(null, nameof(predicate));
            
            return new Runnable<TSource>(predicate);
        }

        public static Runnable<TSource> Except<TSource>(Func<TSource, bool> predicate) 
             => When<TSource>(value => predicate(value) is false);
    }
}