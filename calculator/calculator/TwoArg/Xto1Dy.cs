using System;

namespace calculator.TwoArg
{
   public class Xto1Dy: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}
