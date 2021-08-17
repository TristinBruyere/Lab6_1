using System;
using System.Collections.Concurrent;
using Xunit;
using Lab6_1;

namespace Lab6_1_Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 6)] // Expect to fail
        [InlineData(6, 13)]
        [InlineData(8, 20)] // Expect to fail
        [InlineData(9, 23)]
        public void Test1(int input, int expected)
        {
            Assert.Equal(expected, Program.PrimeNumbers.GetPrime(input));
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(6, false)]
        [InlineData(13, true)]
        [InlineData(20, false)]
        [InlineData(23, true)]
        public void TestIsPrime(int num, bool expected)
        {
            bool result = Program.PrimeNumbers.IsPrime(num);
            Assert.Equal(expected, result);
        }

    }

}
