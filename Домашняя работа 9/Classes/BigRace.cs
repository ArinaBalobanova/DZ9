using System;

namespace Домашнее_задание_9.Classes
{
    class BigRace
    {
        private List<Team> teams;
        public BigRace()
        {
            teams = new List<Team>();
        }
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void StartRace()
        {
            foreach (Team team in teams)
            {
                team.PlayGames();
            }
        }
    }
}
