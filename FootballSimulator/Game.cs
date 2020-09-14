using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FootballSimulator
{
    public class Game
    {
        public static int Time = 90;
        public static void GameProcess() 
        { 
            TeamCreator.BetterTeam(TeamCreator.team1, TeamCreator.team2);
            for (int Count = 0; Count< Time; Count++)
            {
                
                Console.Write($"Minute {Count}. ");
                Event currentEvent = GetEvent();
                Console.Write($"{currentEvent}\n");
                if (Count == 45)
                {
                    GetAssKicked();
                }
                Thread.Sleep(500);
            }
        }

        public static Event GetEvent()
        {
            Random r = new Random();
            int EventProbability = r.Next(1, 100);
            if (EventProbability < 11)
            {
                Goal g = new Goal();
                return g;
            }
            else if (EventProbability > 11 && EventProbability < 16)
            {
                Penalty p = new Penalty();
                return p;
            }
            else if (EventProbability > 16 && EventProbability < 31)
            {
                OffSide o = new OffSide();
                return o;
            }
            else if (EventProbability > 31 && EventProbability < 41)
            {
                Foul f = new Foul();
                return f;
            }
            else
            {
                Idle i = new Idle();
                return i;
            }
        }

        

        public static void GetAssKicked()
        {
            Team t = TeamCreator.LessGoals(TeamCreator.team1, TeamCreator.team2);
            Console.WriteLine($"{t.Name} got their asses kicked.");
        }

    }
}
