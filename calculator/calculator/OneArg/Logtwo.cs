using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArg
{
    public class Logtwo: IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return (1 / Math.Tan(first));
        }
    }
}
