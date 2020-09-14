using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator
{
    public class Team
    {

        public string Name;

        public int Score = 0;

        public int Price;

        public int ProbabilityToScore = 30;

        public GoalKeeper goalKeeper;

    }

    public static class TeamCreator
    {
        public static Team team1 = new Team { Name = "Team1", Price = 30000000 };

        public static Team team2 = new Team { Name = "Team2", Price = 40000000 };

        public static Team LessGoals(Team t1, Team t2)
        {
            if(t1.Score < t2.Score)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }

        public static void BetterTeam(Team t1, Team t2)
        {
            if (t1.Price > t2.Price)
            {
                t1.ProbabilityToScore += 40;
            }
            else t2.ProbabilityToScore += 40;
        }

        public static Team MadeGoal(Team t1, Team t2)
        { 
            Random random = new Random();
            int r = random.Next(1, 101);
            r = random.Next(1, 101);
            r = random.Next(1, 101);
            if (r < t1.ProbabilityToScore)
                return t1;
            else return t2;
        }
    }

}
