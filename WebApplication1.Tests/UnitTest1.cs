using System;
using Xunit;
using WebApplication1.Utilities;

namespace WebApplication1.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1000, 5, 1, 10500)]
        [InlineData(1, 5, 1, 1)]
        [InlineData(-20000, 10, 0.5, 0)]
        [InlineData(2000, 5, 1, 20500)]
        public void Test2(decimal principal, decimal rate, decimal time, decimal sum)
        {
            var save = new Savings();
            var interest = save.InterestCalculator(principal, rate, time);
            Assert.Equal(sum, interest);
        }
    }
}