using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(112, 5, 112)]
        [TestCase(1467, 1466, 1467)]
        [TestCase(77, 1, 77)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
