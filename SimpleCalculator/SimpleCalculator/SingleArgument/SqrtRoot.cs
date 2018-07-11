using System;

namespace SimpleCalculator.SingleArgument
{
    public class SqrtRoot : ISingleArgumentCalculatorcs
            {
                /// <summary>
                /// method, that calculates sqrt(argument)
                /// </summary>
                /// <param name="argument"></param>
                /// <returns>Math.Sqrt(argument)</returns>
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
