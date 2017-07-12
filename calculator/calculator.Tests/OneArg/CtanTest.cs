using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.OneArg
{
    [TestFixture]
   public class CtanTests
    {
        [TestCase(45, 0.5)]
        [TestCase( 180,  1)]
        [TestCase(90, -0.5)]

        public void CtanTest(double firstValue, double expected)
        {
            var calculator = new Ctan();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
    }
}
