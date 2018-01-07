namespace StackTask
{
    /// <summary>
    /// Class contains information about elements called "node" from ctack.
    /// </summary>
    /// <typeparam name="T">T - Generic type, can contain elements with different types</typeparam>
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
