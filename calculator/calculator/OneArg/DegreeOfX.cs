using System;

namespace calculator.OneArg
{
    public class DegreeOfX: IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}
