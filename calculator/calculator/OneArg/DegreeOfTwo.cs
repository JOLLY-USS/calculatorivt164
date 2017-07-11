using System;

namespace calculator.OneArg
{
    public class DegreeOfTwo : IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
