using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void SumTest()
        {
            Assert.AreEqual(5,Calculator.Calculator.Sum(2,3));
        }
    }
}
