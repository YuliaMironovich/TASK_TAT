namespace ListsTask
{
    /// <summary>
    /// Class contains information about elements called "node" from list.
    /// </summary>
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
