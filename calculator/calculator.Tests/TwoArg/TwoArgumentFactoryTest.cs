using System;
using calculator.TwoArg;
using NUnit.Framework;

namespace calculator.Tests.TwoArg
{
   public class TwoArgumentFactoryTests
    {
        [TestCase("plus", typeof(Addition))]
        [TestCase("minus", typeof(Subtraction))]
        [TestCase("generation", typeof(Multiplication))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }


    }
}
