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
                case "xTo1dy":
                    return new Xto1Dy();
                case "logxy":
                    return new LogXY();


                default:
                    throw new Exception("No Opertion");
            }
        }
    }
}
