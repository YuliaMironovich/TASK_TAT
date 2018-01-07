using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackTask;
using System;

namespace Stack.Test
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CreateEmptyStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void CreateEmptyStackAndCheckCountPositive()
        {
            Stack<int> stack = new Stack<int>();
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushFirstElementInStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void PushElementsInStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(5, stack.Count);
        }

        [TestMethod]
        public void PeekFirstElementInEmptyStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        public void PeekFirstElementInStackAndCheckItValuePositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        public void PeekFirstElementInStackAndCheckCount()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            Assert.AreEqual(5, stack.Count);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void PeekFirstElementInEmptyStackNegative()
        {
            Stack<int> stack = new Stack<int>();
            stack.Peek();
        }

        [TestMethod]
        public void PopToptWithOneElementInStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void PopTopInStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void PushElementsInStackAndCheckValueAllElementsUsingPopMethodPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(0, stack.Pop());
        }

        [TestMethod]
        public void PopTopInStackAndCheckNewTopPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            stack.Pop();
            Assert.AreEqual(2, stack.Peek());
        }

        [TestMethod]
        public void PopTopInStackAndCheckCountPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            stack.Pop();
            Assert.AreEqual(4, stack.Count);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void PopTopInEmptyStackNegative()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void PopTopMoreTimesThanNumberOfElementsInEmptyStackNegative()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            for (int i = 6; i > 0; i--)
            {
                stack.Pop();
            }
        }

        [TestMethod]
        public void ClearStackPositive()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 5; i > 0; i--)
            {
                stack.Push(i);
            }
            stack.Clear();
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}
