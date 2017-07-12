using System;

namespace calculator.OneArg
{
    public class Logtwo: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }
}
