using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListsTask.Test
{
    [TestClass]
    public class DoubleLinkedListTests
    {
        [TestMethod]
        public void AddFirstIntElementPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void AddElementPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            Assert.AreEqual(6, list.GetTail().Value);
        }

        [TestMethod]
        public void AddFirstStringElementPositive()
        {
            DoubleLinkedList<string> list = new DoubleLinkedList<string>();
            list.Add("AA");
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void AddSomeIntElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            list.Add(7);
            Assert.AreEqual(3, list.Count());
        }


        [TestMethod]
        public void IsContainsSomeIntElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsTrue(list.IsContain(6));
        }

        [TestMethod]
        public void IsContainsSomeIntElementsNegative()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsFalse(list.IsContain(8));
        }

        [TestMethod]
        public void RemoveIntElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            list.Remove(6);
            Assert.IsFalse(list.IsContain(6));
        }

        [TestMethod]
        public void RemoveSomeIntElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(6);
            list.Add(7);
            list.Remove(6);
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void RemoveIntElementsNegative()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsFalse(list.Remove(8));
        }

        [TestMethod]
        public void RemoveElementsNegative()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            Assert.IsFalse(list.Remove(8));
        }


        [TestMethod]
        public void ClearElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Clear();
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod]
        public void IndexOfElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(0, list.IndexOf(6));
        }


        [TestMethod]
        public void IndexOfSomeElementsPositive()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(0, list.IndexOf(6));
        }


        [TestMethod]
        public void IndexOfElementsNegative()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(-1, list.IndexOf(8));
        }
    }
}


