using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    class MultiplyTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate("multiply");
            double result = calculator.Calculate(14, 2);
            Assert.AreEqual(28, result);
        }
    }
}
