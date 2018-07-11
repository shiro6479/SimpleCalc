using System;

namespace SimpleCalculator.SingleArgument
{
    public class Arcsin : ISingleArgumentCalculatorcs
    {
        /// <summary>
        /// method, that calculates arcsin(argument)
        /// </summary>
        /// <param name="argument"></param>
        /// <returns>Math.Asin(argument)</returns>
        public double SingleCalculate(double argument)
        {
            if (argument < -1 || argument > 1)
            {
                throw new Exception("Арк от больше 1 или от меньше -1");
            }
            return Math.Asin(argument);
        }


    }
}
