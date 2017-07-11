using System;

namespace calculator
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":
                    return new Addition();
                case "minus":
                    return new Subtraction();
                case "generation":
                    return new Multiplication();
                case "division":
                    return new Division();
                case "xdegreey":
                    return new XDegreeY();
                case "xTo1dY":
                    return new Xto1Dy();
                case "logxy":
                    return new LogXY();
                case "Ostxy":
                    return new OstXY();
                case "min":
                    return new Min();
                case "max":
                    return new Max();
                case "Average":
                    return new Average();
                case "Geometric":
                    return new Geometric();
                default:
                    throw new Exception("No Opertion");
            }
        }
    }
}
