using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pandemonium.Test.Extensions.Object
{
    public class CloneTest
    {
        [Fact]
        public void Should_Clone_Object_Values_To_New_Reference()
        {
            Sample value = new() { Value = "value" };

            Sample newValue = value.Clone();

            Assert.False(value.Equals(newValue));
            Assert.Equal(value.Value, newValue.Value);

            value.Value = "another value";

            Assert.NotEqual(value.Value, newValue.Value);
        }

         [Fact]
        public void Should_Clone_IEnumerable_Values_To_New_Reference()
        {
            IEnumerable<Sample> value = new Sample() { Value = "value" }.ToList();

            IEnumerable<Sample> copy = value.Clone();

            Assert.False(value.Equals(copy));
            Assert.Equal(value.First().Value, copy.First().Value);

            value.First().Value = "another value";

            Assert.NotEqual(value.First().Value, copy.First().Value);
        }

        [Fact]
        public void Should_Clone_Array_Values_To_New_Reference()
        {
            int[] value = { 1, 2, 3 };

            int[] copy = value.Clone<int[]>();

            Assert.False(value.Equals(copy));
            Assert.Equal(value.First(), copy.First());
        }
    }

    [Serializable]
    internal class Sample
    {
        public string Value { get; set; }
    }
}
