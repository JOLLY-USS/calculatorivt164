
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class GeometricTests
    {
        [TestCase(10, 10, 10)]
        [TestCase(2, 2, 2)]
        [TestCase(6, 6, 6)]

        public void GeometricTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Geometric();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
