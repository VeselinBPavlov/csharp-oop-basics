namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        // Fields.
        private string name;
        private List<Player> players = new List<Player>();

        // Properties.
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        // Constructor.
        public Team(string name)
        {
            this.Name = name;
        }

        // Methods.
        public double Rating => CalculateRating();

        private double CalculateRating()
        {
            var sum = players.Sum(p => p.PlayerRating);
            return Math.Round(sum, 0);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var player = this.players.FirstOrDefault(p => p.Name == playerName);

            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }

            players.Remove(player);
        }
    }
}
