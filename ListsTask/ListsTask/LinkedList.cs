using System.Collections.Generic;
using System.Collections;

namespace ListsTask
{
    /// <summary>
    /// The class implements a linked list and methods for working with it.
    /// </summary>
    /// <typeparam name="T">T - Generic type, can contain elements with different types.</typeparam>
    public class LinkedList<T>: IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        /// <summary>
        /// Return count of element in List.
        /// </summary>
        public int Count()
        {
            return count;       
        }

        /// <summary>
        /// Add element in tail of list.
        /// </summary>
        /// <param name="value">value of element</param>
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            count++;
        }

        /// <summary>
        /// Remove element with from list.
        /// </summary>
        /// <param name="element">Element for removing.</param>
        /// <returns>True if element removes, else - false.</returns>
        public bool Remove(T element)
        {
            bool removing = false;
            Node<T> current = head;
            Node<T> previous = null;
            int countBeforeRemoving = count;
            while (current != null)
            {
                if (current.Value.Equals(element))
                {
                    if (previous != null)
                    {
                        RemoveElementFromTheMiddleOfList(previous, current);
                    }
                    else
                    {
                        RemoveHeadElement();
                    }
                    count--;
                }
                previous = current;
                current = current.Next;
            }
            if (count < countBeforeRemoving)
            {
                return removing = true;
            }
            return removing;
        }

        /// <summary>
        /// Delete element if it contains in list in the middle or in the tail.
        /// </summary>
        /// <param name="previous">Previous element of current element in list.</param>
        /// <param name="current">Current element in list.</param>
        private void RemoveElementFromTheMiddleOfList(Node<T> previous, Node<T> current)
        {
            previous.Next = current.Next;
            if (current.Next == null)
            {
                tail = previous;
            }
        }

        /// <summary>
        /// Delete the first element in list.
        /// </summary>
        private void RemoveHeadElement()
        {
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
        }

        /// <summary>
        /// Method check the list for containig element.
        /// </summary>
        /// <param name="value">Element for check.</param>
        /// <returns>True if list contains, else - false.</returns>
        public bool IsContain(T value)
        {
            bool containing = false;
            Node<T> current = head;
            while(current != null)
            {
                if (current.Value.Equals(value))
                {
                    return containing = true;
                }
                current = current.Next;
            }
            return containing;
        }

        /// <summary>
        /// The implementation for the list to be enumerated in the external program with a foreach loop, 
        /// the list class implements the IEnumerable interface
        /// </summary>
        /// <returns>Value of element.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        /// <summary>
        /// Method clear the list.
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Method returns the index of element from head element in the list.
        /// </summary>
        /// <param name="value">Value of element.</param>
        /// <returns>Index of element if this element is in list, -1 if element is not in list.</returns>
        public int IndexOf(T value)
        {
            int index = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return index = -1;
        }

        /// <summary>
        /// Method returns the next element of list.
        /// </summary>
        /// <param name="current">Current element of list.</param>
        /// <returns>Next element after the current element.</returns>
        public Node<T> GetNext(Node<T> current)
        {
            if(current.Next != null)
            {
                return current.Next;
            }
            return current = null;
        }

        /// <summary>
        /// Return tail element.
        /// </summary>
        /// <returns>Last element of list</returns>
        public Node<T> GetTail()
        {
            return tail;
        }

        /// <summary>
        /// Return first element.
        /// </summary>
        /// <returns>First element of list</returns>
        public Node<T> GetHead()
        {
            return head;
        }

        public void Sort ()
        {

        }
    }
}
