using System;

namespace calculator.OneArg
{
    public class Logtwo: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (first <= 0)
            {
                throw  new Exception("Вводимое значение меньше или равно 0");
            }
            return Math.Log(first, 2);
        }
    }
}
