namespace Pandemonium.Types
{
    public partial struct Flow<T, TError>
    {
        public static implicit operator Flow<T, TError>(T value)
            => Flow.Of<T, TError>(value);
        
        public static implicit operator Flow<T, TError>(TError error)
            => Flow.Of<T, TError>(error);
    }
}