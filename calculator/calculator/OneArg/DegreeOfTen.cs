using System;

namespace calculator.OneArg
{
    public class DegreeOfTen: IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}
