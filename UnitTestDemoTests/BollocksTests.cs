using System;
using Xunit;
using UnitTestDemo;

namespace UnitTestDemoTests
{
    public class BollocksTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Bollocks b = new Bollocks(5, "bollocks1");

            Assert.Equal(5, b.bollNum);
            Assert.Equal("bollocks1", b.bollString);
        }

        [Theory]
        [InlineData(25, 5, 30)]
        public void AddToTest(int input, int numToAdd, int expected)
        {
            Bollocks c = new Bollocks(input, "bollocks1");
            int result = c.AddTo(numToAdd);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
        public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.DivBy(divisor);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivBy_Zero_Test()
        {
            Bollocks b = new Bollocks(6, "bollocks 2");

            Assert.Throws<DivideByZeroException>(() => b.DivBy(0));
        }

        [Theory]
        [InlineData(30, 10, 0)]
        [InlineData(23, 4, 3)]
        [InlineData(11, 2, 1)]
        public void ModOfDivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.ModOfDivBy(divisor);
            Assert.Equal(expected, result);

        }

    }
}
