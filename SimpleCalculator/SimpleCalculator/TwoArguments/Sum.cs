namespace SimpleCalculator.TwoArguments
{
    public class Sum : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns summary of two numbers
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument + secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }  
    
    }
}
