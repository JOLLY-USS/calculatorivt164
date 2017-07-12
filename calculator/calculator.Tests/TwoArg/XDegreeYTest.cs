using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class XDegreeYTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 9)]
        [TestCase(6, 2, 36)]

        public void XDegreeYTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XDegreeY();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
