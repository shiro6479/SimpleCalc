using NUnit.Framework;
using SimpleCalculator.SingleArgument;

namespace SimpleCalculator.Tests.SingleArgument
{
    [TestFixture]
    class SqrtRootTests
    {
        [Test]
        public void SingleCalculate()
        {
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate("root");
            double result = singlecalculator.SingleCalculate(9);
            Assert.AreEqual(3, result);
        }
    }
}
