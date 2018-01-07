using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListsTask.Test
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void AddFirstIntElementPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void AddElementPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            Assert.AreEqual(6, list.GetTail().Value);
        }

        [TestMethod]
        public void AddFirstStringElementPositive()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("AA");
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void AddSomeIntElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            list.Add(7);
            Assert.AreEqual(3, list.Count());
        }


        [TestMethod]
        public void IsContainsSomeIntElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsTrue(list.IsContain(6));
        }

        [TestMethod]
        public void IsContainsSomeIntElementsNegative()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsFalse(list.IsContain(8));
        }

        [TestMethod]
        public void RemoveIntElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            list.Remove(6);
            Assert.IsFalse(list.IsContain(6));
        }

        [TestMethod]
        public void RemoveSomeIntElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(6);
            list.Add(7);
            list.Remove(6);
            Assert.AreEqual(1, list.Count());
        }

        [TestMethod]
        public void RemoveIntElementsNegative()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.IsFalse(list.Remove(8));
        }

        [TestMethod]
        public void RemoveElementsNegative()
        {
            LinkedList<int> list = new LinkedList<int>();
            Assert.IsFalse(list.Remove(8));
        }


        [TestMethod]
        public void ClearElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Clear();
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod]
        public void IndexOfElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(0, list.IndexOf(6));
        }


        [TestMethod]
        public void IndexOfSomeElementsPositive()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(0, list.IndexOf(6));
        }


        [TestMethod]
        public void IndexOfElementsNegative()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(6);
            list.Add(7);
            Assert.AreEqual(-1, list.IndexOf(8));
        }




    }
}
