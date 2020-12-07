using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns a clone of the object, with a new memory reference. <b>The type must be serializable</b>.
        /// </summary>
        public static T Clone<T>(this T @this)
        {
            using (var stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);
                object newObject = formatter.Deserialize(stream);
                return (T)newObject;
            }
        }
    }
}
