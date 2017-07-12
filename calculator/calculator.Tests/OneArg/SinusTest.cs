using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public partial class SinusTests
    {
        [TestCase(90, 1)]
        [TestCase(180,-1)]
        [TestCase(60, 0)]

        public void Sinus(double firstValue, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}