namespace calculator.TwoArg
{
    public class OstXY : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first%second;
        }
    }
}
