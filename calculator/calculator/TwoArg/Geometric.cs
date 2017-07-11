using System;

namespace calculator.TwoArg
{
    public class Geometric: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first*second);
        }
    }
}
