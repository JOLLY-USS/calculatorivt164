
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class LogXYTests
    {
        [TestCase(10, 10, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(6, 6, 1)]

        public void LogXYTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogXY();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
