﻿namespace calculator.TwoArg
{
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (first + second) / 2;
        }
    }
}
