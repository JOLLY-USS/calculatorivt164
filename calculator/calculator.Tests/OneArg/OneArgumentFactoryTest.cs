using System;
using calculator.OneArg;
using calculator.TwoArg;
using NUnit.Framework;
using Multiplication = calculator.OneArg.Multiplication;

namespace calculator.Tests.OneArg
{
    public class OneArgumentFactoryTests
    {
        [TestCase("sin", typeof(Sinus))]
        [TestCase("cos", typeof(Cosinus))]
        [TestCase("degreeoftwo", typeof(DegreeOfTwo))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
