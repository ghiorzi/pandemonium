namespace Pandemonium.Types
{
    public static partial class Flow
    {
        public static Flow<T, TError> Of<T, TError>(T value)
            => new Flow<T, TError>(value);
        
        public static Flow<T, TError> Of<T, TError>(TError error)
            => new Flow<T, TError>(error);
    }
}