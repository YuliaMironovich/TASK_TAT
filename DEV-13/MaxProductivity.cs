using System;
using System.Collections.Generic;

namespace DEV_13
{
   //First algorithm of employer choise: by max productivity.
   public class MaxProductivity: IStrategy
    {
        private const string TEAM_NOT_FOUND = "Cann't create team with your productivity and cash.";

        //Find teams by the first cryterion
        public List<List<int>> Algorithm(InitialCondition initialCondition)
        {
            Junior junior = new Junior();
            Middle middle = new Middle();
            Senior senior = new Senior();
            Lead lead = new Lead();
            List<int> countOfJunior = new List<int>();
            List<int> countOfMiddle = new List<int>();
            List<int> countOfSenior = new List<int>();
            List<int> countOfLead = new List<int>();
            List<List<int>> countOfEmployee = new List<List<int>>();
            List<int> cost = new List<int>();
            List<int> productivity = new List<int>();
            int maxCountJunior = initialCondition.cash / junior.Salary;
            int maxCountMiddle = initialCondition.cash / middle.Salary;
            int maxCountSenior = initialCondition.cash / senior.Salary;
            int maxCountLead = initialCondition.cash / lead.Salary;
            for (int i = 0; i <= maxCountLead; i++)
            {
                for (int j = 0; j <= maxCountSenior; j++)
                {
                    for (int k = 0; k <= maxCountMiddle; k++)
                    {
                        for (int m = 0; m <= maxCountJunior; m++)
                        {
                            countOfJunior.Add(m);
                            countOfMiddle.Add(k);
                            countOfSenior.Add(j);
                            countOfLead.Add(i);
                        }
                    }
                }
            }
            countOfEmployee.Add(countOfJunior);
            countOfEmployee.Add(countOfMiddle);
            countOfEmployee.Add(countOfSenior);
            countOfEmployee.Add(countOfLead);
            cost = CalculateCostOfTeams(cost, junior, middle, senior, lead, countOfEmployee);
            productivity = CalculateProductivityOfTeams(productivity, junior, middle, senior, lead, countOfEmployee);
            int maxProductivity = 0;
            maxProductivity = SearchMaxProductivity(maxProductivity, countOfEmployee, initialCondition, productivity, cost);
            List<int> numberOfTeam = new List<int>();
            numberOfTeam = FindPossibleTeams(numberOfTeam, countOfEmployee, initialCondition, productivity, cost, maxProductivity);
            List<List<int>> team = new List<List<int>>();
            team = ChooseTeam(numberOfTeam, countOfEmployee, team);
            Output(numberOfTeam, countOfEmployee);
            return team;
        }

        //countOfEmployee[0] = countOfJunior, countOfEmployee[1] = countOfMiddle, countOfEmployee[2] = countOfSenior, countOfEmployee[3] = countOfLead
        //Calculate cost of all teams.
        private List<int> CalculateCostOfTeams(List<int> cost, Junior junior, Middle middle, Senior senior, Lead lead, List<List<int>> countOfEmployee)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                cost.Add(countOfEmployee[0][i] * junior.Salary + countOfEmployee[1][i] * middle.Salary +
                         countOfEmployee[2][i] * senior.Salary + countOfEmployee[3][i] * lead.Salary);
            }
            return cost;
        }
        //Calculate productivity of all teams. 
        private List<int> CalculateProductivityOfTeams(List<int> productivity, Junior junior, Middle middle, Senior senior, Lead lead, List<List<int>> countOfEmployee)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                productivity.Add(countOfEmployee[0][i] * junior.Productivity + countOfEmployee[1][i] * middle.Productivity +
                         countOfEmployee[2][i] * senior.Productivity + countOfEmployee[3][i] * lead.Productivity);
            }
            return productivity;
        }

        //Searsh for the maximum productivity from the teams available for purchase
        private int SearchMaxProductivity(int maxProductivity, List<List<int>> countOfEmployee, InitialCondition initialCondition, List<int> productivity, List<int> cost)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                if (productivity[i] > maxProductivity && cost[i] <= initialCondition.cash)
                {
                    maxProductivity = productivity[i];
                }
            }
            return maxProductivity;
        }

        //Search all possible teams
        private List<int> FindPossibleTeams(List<int> team, List<List<int>> countOfEmployee, InitialCondition initialCondition, List<int> productivity, List<int> cost, int maxProductivity)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                if (productivity[i] == maxProductivity && cost[i] <= initialCondition.cash)
                {
                    team.Add(i);
                }
            }
            return team;
        }

        //Choose and save possible teams
        private List<List<int>> ChooseTeam(List<int> numberOfTeam, List<List<int>> countOfEmployee, List<List<int>> team)
        {
            for (int i = 0; i < numberOfTeam.Count; i++)
            {
                
                team[0].Add(countOfEmployee[0][numberOfTeam[i]]);
                team[1].Add(countOfEmployee[1][numberOfTeam[i]]);
                team[2].Add(countOfEmployee[2][numberOfTeam[i]]);
                team[3].Add(countOfEmployee[3][numberOfTeam[i]]);
            }
            return team;
        }

        //Output posible teams
        private void Output(List<int> team, List<List<int>> countOfEmployee)
        {
            if (team.Count != 0)
            {
                for (int i = 0; i < team.Count; i++)
                {
                    Console.WriteLine("Your Team:");
                    Console.WriteLine("Count of Junior - " + countOfEmployee[0][team[i]]);
                    Console.WriteLine("Count of Middle - " + countOfEmployee[1][team[i]]);
                    Console.WriteLine("Count of Senior - " + countOfEmployee[2][team[i]]);
                    Console.WriteLine("Count of Lead - " + countOfEmployee[3][team[i]]);
                }
            }
            else
            {
                Console.WriteLine(TEAM_NOT_FOUND);
            }
        }
    }
}
