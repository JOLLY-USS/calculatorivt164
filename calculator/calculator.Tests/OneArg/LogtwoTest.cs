using System;
using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class LogtwoTests
    {
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(8, 3)]

        public void Logtwo(double firstValue, double expected)
        {
            var calculator = new Logtwo();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ErrorTest()
        {
            var calculator = new Logtwo();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}