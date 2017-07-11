using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
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
