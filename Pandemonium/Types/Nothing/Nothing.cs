using System;

namespace Pandemonium.Types
{
    /// <summary>
    /// It indicates the absence of a value
    /// </summary>
    public struct Nothing 
    {
        public static Nothing Of()
            => new Nothing();
        
        public Failable<T> Do<T>(Func<Failable<T>> function)
            => function();
    }
}