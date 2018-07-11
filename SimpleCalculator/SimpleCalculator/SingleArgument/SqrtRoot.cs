using System;

namespace SimpleCalculator.SingleArgument
{
    public class SqrtRoot : ISingleArgumentCalculatorcs
            {
                public double SingleCalculate(double argument)
            {
            if (argument < 0)
                {
                    throw new Exception("Корень из отрицательного");
                }
                return Math.Sqrt(argument);
        }
    
    }
}
