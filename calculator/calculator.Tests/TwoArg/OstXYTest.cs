using System;
using System.Runtime.ExceptionServices;
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class OstXYTests
    {
        [TestCase(10, 5, 0)]
        [TestCase(6, 2, 0)]
        [TestCase(6, 3, 0)]

        public void OstXYTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new OstXY();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ErrorTest() 
        {
            var calculator = new OstXY();
            Assert.Throws<Exception>((() => calculator.Calculate(1, 0)));
        }
    }
}
