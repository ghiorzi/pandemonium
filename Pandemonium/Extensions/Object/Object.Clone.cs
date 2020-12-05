using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pandemonium
{
    public static partial class Methods
    {
        /// <summary>
        /// Returns a clone of the object, with a new memory reference. <b>The class needs be Serializable</b>.
        /// </summary>
        public static T Clone<T>(this T @this)
        {
            MemoryStream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, @this);
            stream.Seek(0, SeekOrigin.Begin);
            object newObject = formatter.Deserialize(stream);
            return (T)newObject;
        }
    }
}
