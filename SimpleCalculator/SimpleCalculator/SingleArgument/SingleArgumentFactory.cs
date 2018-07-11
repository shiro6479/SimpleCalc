using System;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.SingleArgument
{
    public class SingleArgumentFactory
    {
        public static ISingleArgumentCalculatorcs CreateSingleCalculate(string name)
        {
            switch (name)
            {
                case "root":
                    return new SqrtRoot();
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "tan":
                    return new Tan();
                case "arcsin":
                    return new Arcsin();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
