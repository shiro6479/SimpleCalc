namespace SimpleCalculator.TwoArguments
{
    public class Sum : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }  
    
    }
}
