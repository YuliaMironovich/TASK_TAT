namespace DEV_13
{
  //Class contains methods which check for validity of contidition.
    public class ValidatorOfCondition
    {
        //Check data for the correctness
        public bool IfValid(InitialCondition initialCondition)
        {
            return IfCorrectCash(initialCondition) && IfCorrectProductivity(initialCondition);           
        }

        //Check for the correctness of the cache
        //Minimum cache should be equal to the salary of the lowest-paid employee
        public bool IfCorrectCash(InitialCondition initialCondition)
        {
            Junior junior = new Junior();
            if (initialCondition.cash >= junior.Salary)
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
