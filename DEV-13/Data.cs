using System;
using System.Collections.Generic;

namespace DEV_13
{
    public class Data
    {
        private const string CASH = "ENTER YOUR CASH:";
        private const string PRODUCTIVITY = "ENTER THE PRODUCTIVITY:";
        private const string CRITERION1 = "ENTER '1' IF CRITERION IS MAXIMUM PRODUCTIVITY WITHIN THE AMOUNT";
        private const string CRITERION2 = "ENTER '2' IF CRITERION IS MINIMUM COST FOR A FIXED PRODUCTIVITY";
        private const string CRITERION3 = "ENTER '3' IF CRITERION IS MINIMUM NUMBER OF EMPLOYEES IS HIGHER THAN JUNIOR FOR FIXED PRODUCTIVITY";
        private const string NO_CRITERION = "YOU DIDN'T CHOOSE CRITERION. TRY AGAIN:";
        private const string ERROR = "CHECK DATA FORMAT! TRY AGAIN: ";
        private const string TEAM_NOT_FOUND = "Cann't create team with your productivity and cash.";

        // Set input data and return choosed criterion
        public InitialCondition Input(InitialCondition initialCondition)
        {      
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    Console.WriteLine(CRITERION1);
                    Console.WriteLine(CRITERION2);
                    Console.WriteLine(CRITERION3);
                    int chosedCriterion = int.Parse(Console.ReadLine());
                    switch (chosedCriterion)
                    {
                        case 1:
                            Console.WriteLine(CASH);
                            initialCondition.cash = int.Parse(Console.ReadLine());
                            initialCondition.criterion = new MaxProductivity();
                            break;
                        case 2:
                            Console.WriteLine(CASH);
                            initialCondition.cash = int.Parse(Console.ReadLine());
                            Console.WriteLine(PRODUCTIVITY);
                            initialCondition.productivity = int.Parse(Console.ReadLine());
                            initialCondition.criterion = new MinCost();
                            break;
                        case 3:
                            Console.WriteLine(CASH);
                            initialCondition.cash = int.Parse(Console.ReadLine());
                            Console.WriteLine(PRODUCTIVITY);
                            initialCondition.productivity = int.Parse(Console.ReadLine());
                            initialCondition.criterion = new MinNumberOfEmployee();
                            break;
                        default:
                            Console.WriteLine(NO_CRITERION);
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine(ERROR);
                    continue;
                }
                continueProgram = false;
            }
            return initialCondition;
        }

        //Output posible teams
        public void Output(List<List<int>> countOfEmployee)
        {
            if (countOfEmployee[0].Count != 0)
            {
                for (int i = 0; i < countOfEmployee[0].Count; i++)
                {
                    Console.WriteLine("Your Team:");
                    Console.WriteLine("Count of Junior - " + countOfEmployee[0][i]);
                    Console.WriteLine("Count of Middle - " + countOfEmployee[1][i]);
                    Console.WriteLine("Count of Senior - " + countOfEmployee[2][i]);
                    Console.WriteLine("Count of Lead - " + countOfEmployee[3][i]);
                }
            }
            else
            {
                Console.WriteLine(TEAM_NOT_FOUND);
            }
        }
    }
}
