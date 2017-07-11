using System;

namespace calculator.OneArg
{
    public class Ctan : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,2);
        }
    }
}
