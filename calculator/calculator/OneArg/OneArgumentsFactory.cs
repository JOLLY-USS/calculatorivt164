using System;

namespace calculator.OneArg
{
    class OneArgumentsFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin":
                    return new Sinus();
                case "cos":
                    return new Cosinus();
                case "degreeoftwo":
                    return new Multiplication();
                case "degreeofx":
                    return new Division();
                case "degreeoften":
                    return new Addition();
                case "module":
                    return new Subtraction();
                case "lognature":
                    return new Multiplication();
                case "tan":
                    return new Division();
                case "ctan":
                    return new Addition();
                case "logtwo":
                    return new Subtraction();
                default:
                    throw new Exception("No Opertion");
            }
        }
    }
}
