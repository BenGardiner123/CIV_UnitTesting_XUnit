using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FactorialRec(int input, int ans)
        {
            CLib = new RecursiveCalc();
            var result = CLib.FactorialRec(input, ans);
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(120, )]
        [InlineData()]
        [InlineData()]
        public void FactorialRec(int input, int ans)
        {
            CLib = new RecursiveCalc();
            var result = CLib.FactorialRec(input, ans);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void FibCheck()
        {

        }

        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        public void PrimeCheckRec()
        {

        }

        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        public void FibonacciRec()
        {

        }

    }
}
