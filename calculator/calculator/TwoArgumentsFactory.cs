using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    throw new Exception("No");
            }
        }
    }
}
