using System;

namespace calculator.TwoArg
{
   public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Вводимое значение равно 0");
            }
            return first / second;
        }
    }
}
