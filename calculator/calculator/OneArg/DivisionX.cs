using System;

namespace calculator.OneArg
{
    public class DivisionX: IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("Вводимое значение равно 0");
            }
            return 1/first;
        }
    }
}
