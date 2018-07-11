using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    class MultiplyTests
    {
        [TestCase(55, 2, 110)]
        [TestCase(3, 3, 9)]
        [TestCase(24, 4, 96)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiply();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
