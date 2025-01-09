using System;


namespace Домашнее_задание_9.Classes
{
    class Team
    {
        public string Name {get;}
        private List<Game> games;

        public Team(string name)
        {
            Name = name;
            games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void PlayGames()
        {
            Console.WriteLine($"Команда {Name} участвует в следующих играх:");
            foreach (Game game in games)
            {
                game.Play();
            }
        }
    }
}
