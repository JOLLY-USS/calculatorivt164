namespace calculator.TwoArg
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (first > second) return second;
            
            else return first;
        }
    }
}
