using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class SumTests
    {
        [TestCase(24, 3, 27)]
        [TestCase(3.3, 4.5, 7.8)]
        [TestCase(-5, -3, -8)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Sum();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
