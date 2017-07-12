using NUnit.Framework;
using calculator.OneArg;

namespace calculator.Tests.OneArg
{
    [TestFixture]
   public class DegreeOfTenTests
    {
        [TestCase(1, 10)]
        [TestCase(0, 1)]
        [TestCase(2, 100)]

        public void DegreeOfTenTest(double firstValue, double expected)
        {
            var calculator = new DegreeOfTen();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
