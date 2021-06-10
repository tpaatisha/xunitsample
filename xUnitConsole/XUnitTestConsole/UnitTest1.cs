using System;
using Xunit;
using xUnitConsole;

namespace XUnitTestConsole
{
    public class UnitTest1
    {
        [Fact]
        public void SumTest()
        {
            var mathTest = new MathClass();
            var A = mathTest.Sum(12,12);
            Assert.Equal(24, A);
        }

        [Fact]
        public void DiffTest()
        {
            var mathTest = new MathClass();
            var A = mathTest.Minus(12, 12);
            Assert.Equal(0, A);
        }
    }
}
