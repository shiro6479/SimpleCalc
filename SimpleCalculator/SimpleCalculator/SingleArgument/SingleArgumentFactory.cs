using System;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.SingleArgument
{
    /// <summary>
    /// factory, that choses a single argument calculating class by its name
    /// </summary>
    public class SingleArgumentFactory
    {
        /// <summary>
        /// method, that choses a single argument calculating class by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>SqrtRoot() or Sin() or Cos() or Tan() or Arcsin()</returns>
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
