
using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.5574077)]
        [TestCase(0.3, 0.3093362)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Tan();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
