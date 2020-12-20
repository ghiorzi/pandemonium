namespace Pandemonium.Types
{
    /// <summary>
    /// It indicates the absence of value;
    /// </summary>
    public struct Nothing 
    {
        public static Nothing Of()
            => new Nothing();
    }
}