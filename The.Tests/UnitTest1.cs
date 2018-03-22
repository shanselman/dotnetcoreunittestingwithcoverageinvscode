using System;
using The.Thing;
using Xunit;

namespace The.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test2()
        {
            Calculator c = new Calculator();
            Assert.Equal(8, c.Add(5,3));
        }

        [Fact]
        public void Test3()
        {
            Calculator c = new Calculator();
            Assert.Equal(4, c.Add(2,2));
        }

        [Fact]
        public void Test1()
        {
            Calculator c = new Calculator();
            Assert.Equal(12,c.Add(5,6));
        }

    }
}
