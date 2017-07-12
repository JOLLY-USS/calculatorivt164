using System;
using System.Security.Cryptography.X509Certificates;
using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public partial class MultiplicationTests
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]

        public void Multiplication(double firstValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ErrorTest()
        {
            var calculator = new Multiplication();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}