using System;
using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class SingleArgumentFactoryTest
    {
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("arcsin", typeof(Arcsin))]
        [TestCase("root", typeof(SqrtRoot))]
        public void SingleCalculateTest(string name, Type type)
        {
            var calculator = SingleArgumentFactory.CreateSingleCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }


    }
}