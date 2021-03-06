﻿using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(5, 3, 2)]
        [TestCase(2, 1, 1)]
        [TestCase(6, 1, 5)]

        public void AdditionTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Subtraction();
            var actualResult = calculator.Calculate(firstValue, secondValue);

            Assert.AreEqual(expected, actualResult);
        }
        
    }
}
