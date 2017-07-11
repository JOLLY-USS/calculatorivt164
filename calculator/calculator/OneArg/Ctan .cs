using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArg
{
    public class Ctan : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,2);
        }
    }
}
