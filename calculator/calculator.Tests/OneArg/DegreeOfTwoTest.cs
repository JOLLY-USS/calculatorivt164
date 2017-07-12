using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class DegreeOfTwoTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(1, 2)]

        public void DegreeOfTwo(double firstValue, double expected)
        {
            var calculator = new DegreeOfTwo();
            var actualResult = calculator.Calculate(firstValue );

            Assert.AreEqual(expected, actualResult);

        }
    }
}