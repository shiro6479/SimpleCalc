using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class ArcsinTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("arcsin");
            double result = singlecalculator.SingleCalculate(0.5);
            Assert.AreEqual(0.5235987, result, 0.0001);
        }
    }
}
