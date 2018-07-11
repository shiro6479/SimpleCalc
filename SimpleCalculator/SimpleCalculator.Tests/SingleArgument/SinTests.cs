using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0.8414709)]
        [TestCase(0.3, 0.2955202)]
        public void CalculateTest(double value, double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.SingleCalculate(value);
            Assert.AreEqual(expected, actualResult, 0.00001);
        }
    }
}
