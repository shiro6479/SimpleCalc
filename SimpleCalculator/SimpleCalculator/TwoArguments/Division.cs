using System;

namespace SimpleCalculator.TwoArguments
{
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns quotient of two numbers
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument / secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
            {
            if (secondArgument == 0)
                {
                    throw new Exception("Деление на 0");
                }
                return firstArgument / secondArgument;
        }
    
    }
}
