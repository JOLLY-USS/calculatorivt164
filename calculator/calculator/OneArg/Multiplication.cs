using System;

namespace calculator.OneArg
{
    public class Multiplication : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
