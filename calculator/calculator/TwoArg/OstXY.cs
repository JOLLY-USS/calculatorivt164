using System;

namespace calculator.TwoArg
{
    public class OstXY : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Введённый знаменатель равен 0");
            }
            return first%second;
        }
    }
}
