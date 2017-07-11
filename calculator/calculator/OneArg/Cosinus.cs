using System;

namespace calculator.OneArg
{
    public class Cosinus: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
