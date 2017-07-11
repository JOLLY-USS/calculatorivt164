using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArg
{
   public class EdegreeX : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
