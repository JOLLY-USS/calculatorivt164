using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArg
{
    public class DivisionX: IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return 1/first;
        }
    }
}
