using System;
using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class DivisionXTests
    {
        [TestCase(2, 0.5)]
        [TestCase(2, 0.5)]
        [TestCase(1, 1)]

        public void DivisionX(double firstValue, double expected)
        {
            var calculator = new DivisionX();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ErrorTest()
        {
            var calculator = new DivisionX();
            Assert.Throws<Exception>((() => calculator.Calculate(0)));
        }
    }
}