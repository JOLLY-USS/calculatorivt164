
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class AverageTests
    {
        [TestCase(10, 10, 10)]
        [TestCase(6, 2, 4)]
        [TestCase(6, 4, 5)]

        public void AverageTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Average();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
