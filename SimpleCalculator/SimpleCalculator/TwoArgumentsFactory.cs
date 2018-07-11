using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class TwoArgumentsFactory
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
