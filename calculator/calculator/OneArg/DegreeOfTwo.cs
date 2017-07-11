﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArg
{
    public class DegreeOfTwo : IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
