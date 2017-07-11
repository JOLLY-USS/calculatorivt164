using System;

namespace calculator.OneArg
{
    public class Tan : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
