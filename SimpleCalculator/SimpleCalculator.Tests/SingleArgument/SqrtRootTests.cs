using System;
using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class SqrtRootTests
    {
        [TestCase(4, 2)]
        [TestCase(144, 12)]
        [TestCase(16, 4)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new SqrtRoot();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void CalculateTest()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");
            Assert.Throws<Exception>(() => singlecalculator.SingleCalculate(-2));
        }
    }
}
