using System;

namespace SimpleCalculator.SingleArgument
{
    public class Sin : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates sin(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Sin(argument)</returns>
        public double SingleCalculate(double argument)
        {
            return Math.Sin(argument);
        }
    
    }
}
