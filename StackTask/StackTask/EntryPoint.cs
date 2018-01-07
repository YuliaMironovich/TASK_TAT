namespace StackTask
{
    /// <summary>
    /// Main class of program of realization stack
    /// contains creating a stack adding and removing elements and it clearing.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            stack.Pop();
            stack.Peek();
            stack.Clear();       
        }
    }
}
