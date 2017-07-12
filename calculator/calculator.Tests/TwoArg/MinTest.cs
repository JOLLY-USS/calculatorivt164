using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(2, 3, 2)]
        [TestCase(3, 2, 2)]
        [TestCase(6, 2, 2)]

        public void MinTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
