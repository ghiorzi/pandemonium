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

            value
                .Clone()
                .Match(
                    value: _ => {
                        Assert.False(value.Equals(_));
                        Assert.Equal(value.Value, _.Value);

                        value.Value = "another value";

                        Assert.NotEqual(value.Value, _.Value);
                    }, 
                    empty: () => throw new Exception("It should not run this block")
                );
        }

         [Fact]
        public void Should_Clone_IEnumerable_Values_To_New_Reference()
        {
            IEnumerable<Sample> value = new Sample() { Value = "value" }.ToList();

            value
                .Clone()
                .Match(
                    value: _ => {
                        Assert.False(value.Equals(_));
                        Assert.Equal(value.First().Value, _.First().Value);

                        value.First().Value = "another value";

                        Assert.NotEqual(value.First().Value, _.First().Value);
                    }, 
                    empty: () => throw new Exception("It should not run this block")
                );
        }

        [Fact]
        public void Should_Clone_Array_Values_To_New_Reference()
        {
            int[] value = { 1, 2, 3 };

            value
                .Clone<int[]>()
                .Match(
                value: _ => {
                    Assert.False(value.Equals(_));
                    Assert.Equal(value.First(), _.First());
                }, 
                empty: () => throw new Exception("It should not run this block")
            );
        }
    }

    [Serializable]
    internal class Sample
    {
        public string Value { get; set; }
    }
}
