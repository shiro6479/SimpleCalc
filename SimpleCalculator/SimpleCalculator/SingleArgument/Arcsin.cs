using System;

namespace SimpleCalculator.SingleArgument
{
    public class Arcsin : ISingleArgumentCalculatorcs
    {
        
        public double SingleCalculate(double argument)
        {
            return Math.Asin(argument);
        }

    }
}
