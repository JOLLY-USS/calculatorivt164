using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(6, 3, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(9, 3, 3)]

        public void AdditionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }

    }
}
