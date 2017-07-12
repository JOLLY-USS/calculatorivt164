
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class Xto1DyTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(9, 2, 3)]
        [TestCase(27, 3, 3)]

        public void Xto1DyTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Xto1Dy();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}