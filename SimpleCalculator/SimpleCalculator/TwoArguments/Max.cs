namespace SimpleCalculator.TwoArguments
{

    public class Max : ITwoArgumentsCalculator
    {
        
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument >= secondArgument)
            {
                return firstArgument;
            }
            return secondArgument;

        }
    }
}
