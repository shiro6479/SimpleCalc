using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculate("minus");
            double result = calculator.Calculate(55, 5);
            Assert.AreEqual(50, result);
        }
    }
}
