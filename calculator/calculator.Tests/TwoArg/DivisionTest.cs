using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            ITwoArgumentsCalculator calcutor = new Division();
            double result = calcutor.Calculate(6, 2);
            Assert. AreEqual(3, result);
        }

    }
}
