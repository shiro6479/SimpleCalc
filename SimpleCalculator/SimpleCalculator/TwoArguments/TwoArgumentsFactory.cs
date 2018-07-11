using System;

namespace SimpleCalculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculate(string name)
        {
            switch (name)
            {
                case "sum":
                    return new Sum();
                case "minus":
                    return new Minus();
                case "multiply":
                    return new Multiply();
                case "division":
                    return new Division();
                case "max":
                    return new Max();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
