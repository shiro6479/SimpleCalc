using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class SinTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("sin");
            double result = singlecalculator.SingleCalculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
