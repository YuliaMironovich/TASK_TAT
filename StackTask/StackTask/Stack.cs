using System;

namespace StackTask
{
    /// <summary>
    /// Class contains information about stack and standarts methods for it using.
    /// </summary>
    public class Stack<T>
    {
        public Node<T> Top { get; private set; }
        public int Count { get; private set; }

        /// <summary>
        /// Constructor sets the values for the top and count ​​of the empty stack.
        /// </summary>
        public Stack()
        {
            Top = null;
            Count = 0;
        }

        /// <summary>
        /// Property returns true if the stack is empty and false if stack is not empty.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        /// <summary>
        /// Method adds element in top of stack.
        /// </summary>
        /// <param name="value">Value of element which is added in stack</param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Top == null)
            {
                Top = node;
            }
            else
            {
                node.Next = Top;
                Top = node;
            }
            Count++;
        }

        /// <summary>
        /// Method remove element from top of the stack.
        /// If the stack is empty, an InvalidOperationException is thrown.
        /// </summary>
        /// <returns>Return value of element which was removed</returns>
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            Node<T> deletedElement = Top;
            Top = Top.Next;
            Count--;
            return deletedElement.Value;
        }

        /// <summary>
        /// Method returns an element from the top of the stack without deleting it.
        ///  If the stack is empty, an InvalidOperationException is thrown.
        /// </summary>
        /// <returns>Returns element from the top</returns>
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return Top.Value;
        }

        /// <summary>
        /// Method clear the stack.
        /// </summary>
        public void Clear()
        {
            while(!IsEmpty)
            {
                Pop();
            }
        }
    }
}
