using System;
using System.Collections.Generic;

namespace test1_task2
{
    /// <summary>
    ///  Main class of the program which count duplicates in collection.
    /// </summary>
    class EntryPoint
    {
        private const string COUNT = "Count of duplicate numbers:";
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 5, 10, 15 };
            Console.WriteLine(COUNT);
            Console.WriteLine(new CollectionCounter().CountNumberOfDuplicates(collection));
            Console.ReadKey();
        }
    }
}
