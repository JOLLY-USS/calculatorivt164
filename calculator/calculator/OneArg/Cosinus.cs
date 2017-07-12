using System;

namespace calculator.OneArg
{
    public class Cosinus: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Round(Math.Cos(first)) ;
        }
    }
}
