namespace Pandemonium.Types
{
    public partial struct Maybe<T>
    {
        public Failable<T> ToFailable()
            => HasValue ? _value : new FailableException();
    }
}