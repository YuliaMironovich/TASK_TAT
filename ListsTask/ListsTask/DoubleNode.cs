namespace ListsTask
{
    /// <summary>
    /// Class contains information about element called nodes from double linked list.
    /// </summary>
    /// <typeparam name="T">Can contain diffent types of element.</typeparam>
    public class DoubleNode<T>
    {
        public DoubleNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public DoubleNode<T> Previous { get; set; }
        public DoubleNode<T> Next { get; set; }
    }
}
