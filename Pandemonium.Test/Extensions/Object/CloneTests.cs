using System;
using System.Runtime.Serialization;
using Xunit;

namespace Pandemonium.Test.Extensions.Object
{
    public class CloneTests
    {
        [Fact]
        public void Should_Clone_Object_Values_To_New_Reference()
        {
            Sample value = new Sample { Anything = "anything" };

            Sample newObject = value.Clone();

            Assert.False(value.Equals(newObject));
            Assert.Equal(value.Anything, newObject.Anything);

            value.Anything = "another";

            Assert.NotEqual(value.Anything, newObject.Anything);
        }

        [Fact]
        public void Should_Throw_SerializationException_Try_Serialize_Non_Serializeble_Class()
        {
            object value = new { Anything = "anything" };
            Assert.Throws<SerializationException>(() => value.Clone());
        }
    }

    [Serializable]
    internal class Sample
    {
        public string Anything { get; set; }

        public override bool Equals(object obj)
        {
            if (!ReferenceEquals(this, obj))
            {
                return false;
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
