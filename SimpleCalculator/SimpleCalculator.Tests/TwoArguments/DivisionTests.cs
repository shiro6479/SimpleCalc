
using System;
using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    class DivisionTests
    {
        [TestCase(18, 3, 6)]
        [TestCase(27, 9, 3)]
        [TestCase(44, 11, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate("division");
            Assert.Throws<Exception>(() => calculator.Calculate(2, 0));

        }
    }
}
