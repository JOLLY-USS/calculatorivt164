using System;

namespace calculator.OneArg
{
   public class EdegreeX : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
