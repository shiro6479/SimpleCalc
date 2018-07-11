using System;

namespace SimpleCalculator.SingleArgument
{
    public class Tan : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates tan(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Tan(argument)</returns>
        public double SingleCalculate(double argument)
        {
            return Math.Tan(argument);
        }

    }
}
