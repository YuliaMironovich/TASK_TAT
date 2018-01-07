using System.Collections.Generic;
using System.Collections;

namespace ListsTask
{
    public class DoubleLinkedList<T>: IEnumerable<T>
    {
        DoubleNode<T> head;
        DoubleNode<T> tail;
        int count;

        /// <summary>
        /// Add element in tail of list.
        /// </summary>
        /// <param name="value">value of element</param>
        public void Add(T value)
        {
            DoubleNode<T> node = new DoubleNode<T>(value);
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
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
            int countBeforeRemoving = count;
            DoubleNode<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(element))
                {
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    count--;
                }
                current = current.Next;
            }
            if (count < countBeforeRemoving)
            {
                return removing = true;
            }
            return removing;
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
            DoubleNode<T> current = head;
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
        /// Method check the list for containig element.
        /// </summary>
        /// <param name="value">Element for check.</param>
        /// <returns>True if list contains, else - false.</returns>
        public bool IsContain(T value)
        {
            bool containing = false;
            DoubleNode<T> current = head;
            while (current != null)
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
        /// Method returns the index of element from head element in the list.
        /// </summary>
        /// <param name="value">Value of element.</param>
        /// <returns>Index of element if this element is in list, -1 if element is not in list.</returns>
        public int IndexOf(T value)
        {
            int index = 0;
            DoubleNode<T> current = head;
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
        public DoubleNode<T> GetNext(DoubleNode<T> current)
        {
            current = current.Next;
            return current;
        }

        /// <summary>
        /// Return tail element.
        /// </summary>
        /// <returns>Last element of list</returns>
        public DoubleNode<T> GetTail()
        {
            return tail;
        }

        /// <summary>
        /// Return first element.
        /// </summary>
        /// <returns>First element of list</returns>
        public DoubleNode<T> GetHead()
        {
            return head;
        }

        /// <summary>
        /// Return count of element in List.
        /// </summary>
        public int Count()
        {
            return count;
        }
    }
}
