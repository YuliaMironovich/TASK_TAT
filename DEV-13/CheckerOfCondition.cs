namespace DEV_13
{
    class CheckerOfCondition
    {
        //Check data for the correctness
        public bool IfCorrect(InitialCondition initialCondition)
        {
            if (IfCorrectCash(initialCondition) && IfCorrectProductivity(initialCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check for the correctness of the cache
        //Minimum cache should be equal to the salary of the lowest-paid employee
        public bool IfCorrectCash(InitialCondition initialCondition)
        {
            Junior junior = new Junior();
            if (initialCondition.cash >= junior.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check for the correctness of the productivity
        //Productivity can not be a negative number
        public bool IfCorrectProductivity(InitialCondition initialCondition)
        {
            if (initialCondition.productivity >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
