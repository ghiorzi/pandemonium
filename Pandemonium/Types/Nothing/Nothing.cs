using System;

namespace Pandemonium.Types
{
    /// <summary>
    /// It indicates the absence of a value
    /// </summary>
    public readonly struct Nothing 
    {
        public static Nothing Of()
            => new ();
        
        // It must not be a static method since we want method chaining
        #pragma warning disable CA1822
        public Failable<T> Do<T>(Func<Failable<T>> function)
            => function();
    }
}