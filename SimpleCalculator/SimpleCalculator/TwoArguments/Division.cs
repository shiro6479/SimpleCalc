namespace SimpleCalculator.TwoArguments
{
    public class Division : ITwoArgumentsCalculator
    {
         public double Calculate(double firstArgument, double secondArgument)
            {
               return firstArgument / secondArgument;
            }
    
    }
}
