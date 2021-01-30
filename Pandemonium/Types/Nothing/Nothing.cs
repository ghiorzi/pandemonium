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
        
        /// <summary>
        /// It allows to start a flow
        /// </summary>
        /// <param name="function">Function that will be invoked</param>
        public Flow<T, TError> Then<T, TError>(Func<Flow<T, TError>> function)
            => function();
    }
}