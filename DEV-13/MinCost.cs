using System;
using System.Collections.Generic;

namespace DEV_13
{
    public class MinCost: IStrategy
    {
        private const string TEAM_NOT_FOUND = "Cann't create team with your productivity and cash.";

        //Find teams by the second cryterion
        public void Algorithm(InitialCondition initialCondition)
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
            int maxCountJunior = initialCondition.cash / junior.salary;
            int maxCountMiddle = initialCondition.cash / middle.salary;
            int maxCountSenior = initialCondition.cash / senior.salary;
            int maxCountLead = initialCondition.cash / lead.salary;
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
            int minCost = Int32.MaxValue;
            minCost = SearchMinCost(minCost, countOfEmployee, initialCondition, productivity, cost);
            List<int> team = new List<int>();
            team = FindPossibleTeams(team, countOfEmployee, initialCondition, productivity, cost, minCost);
            Output(team, countOfEmployee);
        }
        
        // countOfEmployee[0] = countOfJunior, countOfEmployee[1] = countOfMiddle, countOfEmployee[2] = countOfSenior, countOfEmployee[3] = countOfLead
        //Calculate cost of all teams.
        private List<int> CalculateCostOfTeams(List<int> cost, Junior junior, Middle middle, Senior senior, Lead lead, List<List<int>> countOfEmployee)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                cost.Add(countOfEmployee[0][i] * junior.salary + countOfEmployee[1][i] * middle.salary +
                         countOfEmployee[2][i] * senior.salary + countOfEmployee[3][i] * lead.salary);
            }
            return cost;
        }

        //Calculate productivity of all teams. 
        private List<int> CalculateProductivityOfTeams(List<int> productivity, Junior junior, Middle middle, Senior senior, Lead lead, List<List<int>> countOfEmployee)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                productivity.Add(countOfEmployee[0][i] * junior.productivity + countOfEmployee[1][i] * middle.productivity +
                         countOfEmployee[2][i] * senior.productivity + countOfEmployee[3][i] * lead.productivity);
            }
            return productivity;
        }

        //Searsh for the minimum cost with fix productivity from the teams available for purchase
        private int SearchMinCost(int minCost, List<List<int>> countOfEmployee, InitialCondition initialCondition, List<int> productivity, List<int> cost)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                if (productivity[i] == initialCondition.productivity && cost[i] <= initialCondition.cash)
                {
                    if (minCost > cost[i])
                    {
                        minCost = cost[i];
                    }
                }
            }
            return minCost;
        }

        //Search all possible teams
        private List<int> FindPossibleTeams(List<int> team, List<List<int>> countOfEmployee, InitialCondition initialCondition, List<int> productivity, List<int> cost, int minCost)
        {
            for (int i = 0; i < countOfEmployee[0].Count; i++)
            {
                if (cost[i] == minCost && productivity[i] == initialCondition.productivity && minCost <= initialCondition.cash)
                {
                    team.Add(i);
                }
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
