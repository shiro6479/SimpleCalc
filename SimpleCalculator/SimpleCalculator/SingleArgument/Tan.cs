using System;

namespace SimpleCalculator.SingleArgument
{
    public class Tan : ISingleArgumentCalculatorcs
    {
        public double SingleCalculate(double argument)
        {
            return Math.Tan(argument);
        }

    }
}
