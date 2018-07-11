using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Tan : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Tan(argument);
        }

    }
}
