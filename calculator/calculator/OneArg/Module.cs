using System;

namespace calculator.OneArg
{
    public class Module: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
