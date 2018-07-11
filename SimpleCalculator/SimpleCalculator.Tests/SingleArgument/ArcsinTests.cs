using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class ArcsinTests
    {
        [TestCase(0.5, 0.5235987)]
        [TestCase(0.3, 0.3046926)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
