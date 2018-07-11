using System;
using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    class TwoArgumentsFactoryTest
    {
        [TestCase("sum", typeof(Sum))]
        [TestCase("minus", typeof(Minus))]
        [TestCase("multiply", typeof(Multiply))]
        [TestCase("division", typeof(Division))]
        [TestCase("max", typeof(Max))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculate(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}