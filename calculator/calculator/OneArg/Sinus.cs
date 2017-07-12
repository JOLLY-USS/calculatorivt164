using System;

namespace calculator.OneArg
{
    public class Sinus : IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Round(Math.Sin(first));
        }
    }
}
