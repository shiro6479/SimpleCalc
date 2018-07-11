using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    public class SumTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate("sum");
            double result = calculator.Calculate(16, 2);
            Assert.AreEqual(18, result);
        }
    }
}
