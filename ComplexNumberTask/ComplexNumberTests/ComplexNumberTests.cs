using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumberTask;

namespace ComplexNumberTests
{
    [TestClass]
    public class ComplexNumberTests
    {
        [TestMethod]
        public void ToStingWithCorrectIntNumberPositive()
        {
            Assert.AreEqual("2 + i * 3", new ComplexNumber(2, 3).ToString());
        }

        [TestMethod]
        public void ToStingWithCorrectDoubleNumberPositive()
        {
            Assert.AreEqual("2,003 + i * 3,1", new ComplexNumber(2.003, 3.1).ToString());
        }

        [TestMethod]
        public void ToStingForCorrectDisplayNumberNegative()
        {
            Assert.AreNotEqual("2+ i * 3", new ComplexNumber(2, 3).ToString());
        }

        [TestMethod]
        public void GetModulOfComplexNumberWithCorrectDataPositive()
        {
            Assert.AreEqual(5, new ComplexNumber(3, 4).GetModulOfComplexNumber());
        }

        [TestMethod]
        public void GetModulOfComplexNumberWithCorrectDoubleDataPositive()
        {
            Assert.AreEqual(5, new ComplexNumber(3.0, 4.0).GetModulOfComplexNumber());
        }

        [TestMethod]
        public void SumOfComplexNumberWithCorrectDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(4, 6).ToString(), (new ComplexNumber(3, 4) + new ComplexNumber(1, 2)).ToString());
        }

        [TestMethod]
        public void SumOfComplexNumberegative()
        {
            Assert.(new ComplexNumber(double.MaxValue, double.MaxValue) + new ComplexNumber(int.MaxValue, int.MaxValue));
        }

        [TestMethod]
        public void SumOfComplexNumberWithCorrectDoubleDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(4.2, 6.2).ToString(), (new ComplexNumber(3.1, 4.1) + new ComplexNumber(1.1, 2.1)).ToString());
        }

        [TestMethod]
        public void DifferenceOfComplexNumberWithCorrectDoubleDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(2, 2).ToString(), (new ComplexNumber(3.1, 4.1) - new ComplexNumber(1.1, 2.1)).ToString());
        }

        [TestMethod]
        public void DifferenceOfComplexNumberWithCorrectDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(2, 2).ToString(), (new ComplexNumber(3, 4) - new ComplexNumber(1, 2)).ToString());
        }

        [TestMethod]
        public void MultiplicateOfComplexNumberWithCorrectDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(-1, 8).ToString(), (new ComplexNumber(3, 2) * new ComplexNumber(1, 2)).ToString());
        }

        [TestMethod]
        public void MultiplicateOfComplexNumberWithCorrectDoubleDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(-1, 9.68).ToString(), (new ComplexNumber(3.2, 2.2) * new ComplexNumber(1.2, 2.2)).ToString());
        }

        [TestMethod]
        public void DivisionOfComplexNumberWithCorrectDataPositive()
        {
            Assert.AreEqual(new ComplexNumber(1.4, -0.8).ToString(), (new ComplexNumber(3, 2) / new ComplexNumber(1, 2)).ToString());
        }
        

    }
}
