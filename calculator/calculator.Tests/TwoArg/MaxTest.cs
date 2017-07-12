using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    class MaxTest
    {
        [TestCase(2, 3, 3)]
        [TestCase(3, 2, 3)]
        [TestCase(6, 2, 6)]

        public void MinTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
