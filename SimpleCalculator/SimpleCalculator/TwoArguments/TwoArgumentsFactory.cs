using System;

namespace SimpleCalculator.TwoArguments
{
    /// <summary>
    /// factory, that choses a  two argument calculating class by its name
    /// </summary>
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// that choses a  two argument calculating class by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Sum() or Minus() or Multiply() or Division() or Max()</returns>
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
