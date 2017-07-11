using System;

namespace calculator.TwoArg
{
   public class LogXY: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
