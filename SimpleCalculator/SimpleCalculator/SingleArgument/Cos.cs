using System;

namespace SimpleCalculator.SingleArgument
{
    public class Cos : ISingleArgumentCalculatorcs
    {
      
        public double SingleCalculate(double argument)
        {
            return Math.Cos(argument);
        }

    }
}
