using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1_task3.Test
{
    [TestClass]
    public class ValidatorOfAutomobileParametersTests
    {
        [TestMethod]
        public void IsValidWithCorrectTypeSedanOfAutomobilePositive()
        {
            Assert.IsTrue(new ValidatorOfAutomobileParameters().IsValid("sedan", 200));
        }

        [TestMethod]
        public void IsValidWithCorrectTypeEstateOfAutomobilePositive()
        {
            Assert.IsTrue(new ValidatorOfAutomobileParameters().IsValid("estate", 200));
        }

        [TestMethod]
        public void IsValidWithCorrectTypeSUVOfAutomobilePositive()
        {
            Assert.IsTrue(new ValidatorOfAutomobileParameters().IsValid("SUV", 200));
        }

        [TestMethod]
        public void IsValidWithInCorrectTypeOfAutomobileNegative()
        {
            Assert.IsFalse(new ValidatorOfAutomobileParameters().IsValid("type", 200));
        }

        [TestMethod]
        public void IsValidWithDifferentRegisterOfAutomobileTypePositive()
        {
            Assert.IsTrue(new ValidatorOfAutomobileParameters().IsValid("sEdAn", 200));
        }

        [TestMethod]
        public void IsValidWithCorrectPriceOfAutomobilePositive()
        {
            Assert.IsTrue(new ValidatorOfAutomobileParameters().IsValid("sedan", 200));
        }

        [TestMethod]
        public void IsValidWithNegativePriceOfAutomobileNegative()
        {
            Assert.IsFalse(new ValidatorOfAutomobileParameters().IsValid("sedan", -5));
        }

        [TestMethod]
        public void IsValidWithNullPriceOfAutomobileNegative()
        {
            Assert.IsFalse(new ValidatorOfAutomobileParameters().IsValid("sedan", 0));
        }
    }
}
