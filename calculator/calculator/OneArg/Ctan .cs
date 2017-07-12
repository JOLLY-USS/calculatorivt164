using System;

namespace calculator.OneArg
{
    public class Ctan : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1 / Math.Round(Math.Tan(first));
            
        }
    }
}
