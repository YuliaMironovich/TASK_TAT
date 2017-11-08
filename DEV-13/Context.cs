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
        public void ExecuteOperation(InitialCondition initialCondition)
        {
            selectedStrategy.Algorithm(initialCondition);
        }
    }
}
