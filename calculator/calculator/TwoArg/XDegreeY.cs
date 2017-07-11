using System;

namespace calculator.TwoArg
{
    public class XDegreeY: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
