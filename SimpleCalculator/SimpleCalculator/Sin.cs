using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Sin : ISingleArgumentCalculatorcs
    {
        
        public double SingleCalculate(double argument)
        {
            return Math.Sin(argument);
        }
    
    }
}
