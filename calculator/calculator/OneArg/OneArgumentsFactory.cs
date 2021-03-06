﻿using System;

namespace calculator.OneArg
{
    public class OneArgumentsFactory
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
                    return new DegreeOfTwo();
                case "degreeofx":
                    return new DegreeOfX();
                case "degreeoften":
                    return new DegreeOfTen();
                case "module":
                    return new Module();
                case "lognature":
                    return new Multiplication();
                case "tan":
                    return new Tan();
                case "ctan":
                    return new Ctan();
                case "logtwo":
                    return new Logtwo();
                case "EdegreeX":
                    return new EdegreeX();
                case "DivisionX":
                    return new DivisionX();
                default:

                    throw new Exception("No Opertion");
            }
        }
    }
}
