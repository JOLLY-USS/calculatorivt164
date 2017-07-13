using System;

namespace calculator.TwoArg
{
   public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Делить на 0 незя");
            }
            return first / second;
        }
    }
}
