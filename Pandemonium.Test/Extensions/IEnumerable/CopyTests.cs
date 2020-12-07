using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Xunit;

namespace Pandemonium.Test.Extensions.IEnumerable
{
    public class CopyTests
    {
        [Fact]
        public void Should_Clone_IEnumerable_Values_To_New_Reference()
        {
            IEnumerable<Sample> value = new List<Sample> { new Sample { Anything = "anything" } };

            IEnumerable<Sample> copy = value.Copy();

            Assert.False(value.Equals(copy));
            Assert.Equal(value.First().Anything, copy.First().Anything);

            value.First().Anything = "another";

            Assert.NotEqual(value.First().Anything, copy.First().Anything);
        }

        [Fact]
        public void Should_Clone_Array_Values_To_New_Reference()
        {
            int[] value = { 1, 2, 3 };

            int[] copy = (int[])value.Copy();

            Assert.False(value.Equals(copy));
            Assert.Equal(value.First(), copy.First());
        }

        [Fact]
        public void Should_Throw_SerializationException_Try_Serialize_Non_Serializeble_IEnumerable_Class()
        {
            IEnumerable<object> value = new List<object> { new { Anything = "anything" } };
            Assert.Throws<SerializationException>(() => value.Copy());
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
}
