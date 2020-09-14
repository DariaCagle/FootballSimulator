using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator
{
    abstract public class Event
    {

        public override string ToString()
        {
            return "";
        }

    }

    public class Idle : Event
    {
        public override string ToString()
        {
            return "Nothing happened.";
        }

    }

    public class Goal : Event
    {
        public Team ScoredTeam;

        public Goal()
        {
            Team goalTeam = TeamCreator.MadeGoal(TeamCreator.team1, TeamCreator.team2);
            goalTeam.Score++;
            ScoredTeam = goalTeam;
        }
        public override string ToString()
        {
            return $"Team {ScoredTeam.Name} scored a goal!";
        }

        public Team team;
    }

    public class Foul : Event
    {
        public Foul()
        {
            Game.Time++;
        }
        public override string ToString()
        {
            return "Foul.";
        }
    }

    public class OffSide : Event
    {
        public override string ToString()
        {
            return "Offside.";
        }
    }

    public class Penalty : Event
    {
        public Penalty()
        {
            Game.Time++;
        }
        public override string ToString()
        {
            return "Penalty.";
        }
    }
}
