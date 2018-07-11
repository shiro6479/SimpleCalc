using System;

namespace SimpleCalculator.SingleArgument
{
    public class Sin : ISingleArgumentCalculatorcs
    {
        
        public double SingleCalculate(double argument)
        {
            return Math.Sin(argument);
        }
    
    }
}
