namespace SimpleCalculator.TwoArguments
{
    public class Minus : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    
    }
}
