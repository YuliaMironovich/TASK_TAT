using System;
using System.Collections.Generic;

namespace test1_task3
{
    /// <summary>
    /// Class implemets interface IComparer and realizes method Compare.
    /// </summary>
    public class AutomobileSorter :IComparer<Automobile>
    {
        /// <summary>
        /// Method compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="automobile">The first object to compare.</param>
        /// <param name="nextAutomobile">The second object to compare.</param>
        /// <returns>A signed integer: -1 - first object less than second object, 0 - first object equals second object, 1 - 0 - first object is greater than second object. </returns>
        public int Compare(Automobile automobile, Automobile nextAutomobile)
        {
            int result = automobile.Price.CompareTo(nextAutomobile.Price);
            if (result != 0)
            {
                return result / Math.Abs(result);
            }
            result = automobile.Type.CompareTo(nextAutomobile.Type);
            if (result != 0 )
            {
                return result / Math.Abs(result);
            }
            result = automobile.Brand.CompareTo(nextAutomobile.Brand);
            if (result != 0)
            {
                return result / Math.Abs(result);
            }
            return result;
        }
    }
}
