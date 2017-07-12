
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public partial class MultiplicationTests
    {
        [TestCase(10, 10, 100)]
        [TestCase(4, 2, 8)]
        [TestCase(6, 6, 36)]

        public void MultiplicationTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
