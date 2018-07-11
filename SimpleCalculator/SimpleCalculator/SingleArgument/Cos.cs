using System;

namespace SimpleCalculator.SingleArgument
{
    public class Cos : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates cos(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Cos(argument)</returns>
        public double SingleCalculate(double argument)
        {      
                return Math.Cos(argument);
        }

    }
}
