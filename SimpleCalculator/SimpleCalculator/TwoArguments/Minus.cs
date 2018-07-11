namespace SimpleCalculator.TwoArguments
{
    public class Minus : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that returns difference between two numbers
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument - secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    
    }
}
