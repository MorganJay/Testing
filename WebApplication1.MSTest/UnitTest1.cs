using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Utilities;

namespace WebApplication1.MSTest
{
    [TestClass]
    public class SavingsTests
    {
        [TestMethod]
        public void Interest()
        {
            // Arrange
            decimal principal = 10000;
            decimal rate = 5;
            decimal time = 1;
            decimal expectedInterest = 10500;

            //Act
            var save = new Savings();
            var sum = save.InterestCalculator(principal, rate, time);

            //Assert
            Assert.AreEqual(expectedInterest, sum);
        }
    }
}