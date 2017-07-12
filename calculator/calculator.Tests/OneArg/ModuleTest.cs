using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.OneArg
{
    [TestFixture]
    public class ModuleTests
    {
        [TestCase(-5, 5)]
        [TestCase(6, 6)]
        [TestCase(-2,2)]

        public void ModuleTest(double firstValue, double expected)
        {
            var calculator = new Module();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }

    }
}