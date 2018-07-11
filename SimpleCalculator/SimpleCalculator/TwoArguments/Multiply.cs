namespace SimpleCalculator.TwoArguments
{
    public class Multiply : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method, that multiplies two numbers
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>firstArgument * secondArgument</returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    
    }
}
