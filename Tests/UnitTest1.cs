using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(120, 5, 1)]
        [InlineData(24, 4, 1)]
        [InlineData(720, 6, 1)]
        public void FactorialRec(int expected, int input, int ans)
        {
            var CLib = new RecursiveCalc();
            var result = CLib.FactorialRec(input, ans);
            Assert.Equal(expected, result);
        }


         [Fact]
        public void FibCheck()
        {   
            int input1 = 13;
            int input2 = 10; 
            int input3 = 2; 
            var CLib = new RecursiveCalc();
            Assert.Equal(true, CLib.FibCheck(input1));
            Assert.Equal(false, CLib.FibCheck(input2));
            Assert.Equal(true, CLib.FibCheck(input3));
        }

        [Fact]
        public void PrimeCheckZeroErrorRec()
        {   
            var CLib = new RecursiveCalc();
            Assert.Throws<DivideByZeroException>(() => CLib.PrimeCheckRec(10, 0));
        }


        [Theory]
        [InlineData(true, 107, 2)]
        [InlineData(false, 4, 2)]
        [InlineData(true, 19, 2)]
        public void PrimeCheckRec(bool expected, int num, int divisor)
        {

            var CLib = new RecursiveCalc();
            var result = CLib.PrimeCheckRec(num, divisor);
            Assert.Equal(expected, result);
        } 

        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        public void FibonacciRec(int expected, int num1, int num2, int numFibs)
        {
            var CLib = new RecursiveCalc();
            var result = CLib.FibonacciRec(num1, num2, numFibs);
            Assert.Equal(expected, result);
        } 
 
    }
}
