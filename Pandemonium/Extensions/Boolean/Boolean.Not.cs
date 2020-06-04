namespace Pandemonium.Extensions
{
    public static partial class Methods
    {
        /// <summary>
        /// Inverts the value (true => false, false => true)
        public static bool Not(this bool @this) => !@this;
    }
}