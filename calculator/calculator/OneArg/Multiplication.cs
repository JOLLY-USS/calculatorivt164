using System;

namespace calculator.OneArg
{
    public class Multiplication : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Вводимое значение меньше или равно 0");
            }
            return Math.Log10(first);
        }
    }
}
