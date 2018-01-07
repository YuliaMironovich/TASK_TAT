using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1_task3.Test
{
    [TestClass]
    public class AutomobileSorterTests
    {
        [TestMethod]
        public void CompareAutomobilesWithDifferentsPriceAndOtherEqualParametersPositive()
        {
            Assert.AreEqual(1, new AutomobileSorter().Compare(new Automobile("A", "a", "sedan", 200), new Automobile("A", "a", "sedan", 100)));
        }

        [TestMethod]
        public void CompareAutomobilesWithDifferentTypeAndOtherEqualParametersPositive()
        {
            Assert.AreEqual(1, new AutomobileSorter().Compare(new Automobile("A", "a", "sedan", 200), new Automobile("A", "a", "estate", 200)));
        }

        [TestMethod]
        public void CompareAutomobilesWithDifferentTypesAndOtherEqualParametersPositive()
        {
            Assert.AreEqual(-1, new AutomobileSorter().Compare(new Automobile("A", "a", "sedan", 200), new Automobile("A", "a", "SUV", 200)));
        }

        [TestMethod]
        public void CompareAutomobilesWithDifferentBrandsAndOtherEqualParametersPositive()
        {
            Assert.AreEqual(1, new AutomobileSorter().Compare(new Automobile("B", "b", "sedan", 200), new Automobile("A", "a", "sedan", 200)));
        }

        [TestMethod]
        public void CompareAutomobilesWithAllEqualParametersPositive()
        {
            Assert.AreEqual(0, new AutomobileSorter().Compare(new Automobile("B", "b", "sedan", 200), new Automobile("B", "b", "sedan", 200)));
        }


    }
}
