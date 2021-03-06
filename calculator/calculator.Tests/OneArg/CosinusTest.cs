﻿using calculator.OneArg;
using NUnit.Framework;

namespace calculator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1)]
        [TestCase(90, 0)]
        [TestCase(180, -1)]

        public void CosinusTest(double firstValue, double expected)
        {
            var calculator = new Cosinus();
            var actualResult = calculator.Calculate(firstValue);

            Assert.AreEqual(expected, actualResult);
        }

    }
}
