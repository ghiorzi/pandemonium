using System;

namespace Pandemonium.Types
{
    public static class Throw<TSource, TResult> where TResult : Exception, new ()
    {     
        public static Catchable<TSource, TResult> When(Func<TSource, bool> predicate) 
        {
            if (predicate is null)
                throw new ArgumentException(null, nameof(predicate));
            
            return new Catchable<TSource, TResult>(predicate);
        }

        public static Catchable<TSource, TResult> Except(Func<TSource, bool> predicate) 
             => When(value => predicate(value) is false);
    }
}