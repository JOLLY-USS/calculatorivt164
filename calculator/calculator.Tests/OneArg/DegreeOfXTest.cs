using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class DegreeOfXTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        [TestCase(1, 1)]

        public void DegreeOfX(double firstValue, double expected)
        {
            var calculator = new DegreeOfX();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}