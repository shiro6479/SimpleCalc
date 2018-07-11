using SimpleCalculator.SingleArgument;
using NUnit.Framework;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class CosTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("cos");
            double result = singlecalculator.SingleCalculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
