using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AdditionTest()
        {
            ITwoArgumentsCalculator calculator= new Addition();
            double result = calculator.Calculate(2,5);
            Assert.AreEqual(7, result);
        }

    }
}
