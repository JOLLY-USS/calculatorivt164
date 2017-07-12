using System.Runtime.ExceptionServices;
using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [Test]
        public void CosinusTest()
        {
            IOneArgumentCalculator calculator = new Cosinus();
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
