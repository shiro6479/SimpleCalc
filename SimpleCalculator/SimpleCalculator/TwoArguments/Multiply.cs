namespace SimpleCalculator.TwoArguments
{
    public class Multiply : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    
    }
}
