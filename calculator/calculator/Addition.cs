﻿namespace calculator
{
    public  class Addition : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }

    }
}
