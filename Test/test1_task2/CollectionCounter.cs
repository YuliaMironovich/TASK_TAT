using System.Collections.Generic;

namespace test1_task2
{
    /// <summary>
    /// Class contains methods for counting duplicates in collection.
    /// </summary>
    public class CollectionCounter
    {

        /// <summary>
        /// Method returns the calculated number of repeating elements using LastIndex
        /// to find occurrence index of the element.
        /// </summary>
        /// <param name="list">List for counting duplicates.</param>
        /// <returns></returns>
        public int CountNumberOfDuplicates(List<int> list)
        {
            list.Sort();
            int countOfDuplicates = 0;
            int lastIndex = 0;
            for (int i = 0; i < list.Count - 1; i++)
            { 
                lastIndex = list.LastIndexOf(list[i]);
                if(lastIndex > i)
                {
                    countOfDuplicates++;
                }
                i = lastIndex;
            }
            return countOfDuplicates;
        }
    }
}
