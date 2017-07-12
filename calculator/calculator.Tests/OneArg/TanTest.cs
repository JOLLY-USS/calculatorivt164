using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.OneArg
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(45, 2)]
        [TestCase(135, 0)]
        [TestCase(90, -2)]

        public void TanTest(double firstValue, double expected)
        {
            var calculator = new Tan();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
