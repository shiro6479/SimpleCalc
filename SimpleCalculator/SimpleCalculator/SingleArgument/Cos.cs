using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Cos : ISingleArgumentCalculatorcs
    {
      
        public double SingleCalculate(double argument)
        {
            return Math.Cos(argument);
        }

    }
}
