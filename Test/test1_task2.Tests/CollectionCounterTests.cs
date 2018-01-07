using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1_task2.Tests
{
    [TestClass]
    public class CollectionCounterTests
    {
        [TestMethod]
        public void CountNumberOfDuplicatesWithNullCollectionPositive()
        {
            List<int> list = new List<int>();
            Assert.AreEqual(0, new CollectionCounter().CountNumberOfDuplicates(list));
        }

        [TestMethod]
        public void CountNumberOfDuplicatesWithDifferentValuesOfCollectionPositive()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Assert.AreEqual(0, new CollectionCounter().CountNumberOfDuplicates(list));
        }

        [TestMethod]
        public void CountNumberOfDuplicatesWithAllSameValuesOfCollectionPositive()
        {
            List<int> list = new List<int>() {3, 3, 3 };
            Assert.AreEqual(1, new CollectionCounter().CountNumberOfDuplicates(list));
        }

        [TestMethod]
        public void CountNumberOfDuplicatesWithTwoSameValuesOfCollectionPositive()
        {
            List<int> list = new List<int>() { 1, 1, 3, 3 };
            Assert.AreEqual(2, new CollectionCounter().CountNumberOfDuplicates(list));
        }

        [TestMethod]
        public void CountNumberOfDuplicatesWithNegativeAndSameValuesOfCollectionPositive()
        {
            List<int> list = new List<int>() { -1, 1, 3, 3 };
            Assert.AreEqual(1, new CollectionCounter().CountNumberOfDuplicates(list));
        }

        [TestMethod]
        public void CountNumberOfDuplicatesWithAllNullValuesOfCollectionPositive()
        {
            List<int> list = new List<int>() { 0, 0, 0, 0 };
            Assert.AreEqual(1, new CollectionCounter().CountNumberOfDuplicates(list));
        }
    }
}
