using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SubstactionTest()
        {
           ITwoArgumentsCalculator calculator = new Subtraction();
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(3, result);
        }
    }
}
