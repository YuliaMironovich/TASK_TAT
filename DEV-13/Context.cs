using System.Collections.Generic;

namespace DEV_13
{
   public class Context
    {
        private IStrategy selectedStrategy;
        
        public Context(IStrategy strategy)
        {
            selectedStrategy = strategy;
        }

        //Method for the choice strategy
        public void SetStrategy(IStrategy strategy)
        {
            selectedStrategy = strategy;
        }

        //Start execution of the algorithm of the chosen strategy
        public List<List<int>> ExecuteOperation(InitialCondition initialCondition)
        {
            List<List<int>> result =  selectedStrategy.Algorithm(initialCondition);
            return result;
        }
    }
}
