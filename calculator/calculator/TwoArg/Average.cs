﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Average : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (first + second) / 2;
        }
    }
}
