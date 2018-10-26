namespace FootballTeamGenerator
{
    using System;
    using System.Linq;

    public class Player
    {
        // Constants.
        private const int MIN_STAT_POINTS = 0;
        private const int MAX_STAT_POINTS = 100;        

        // Fields.
        private string name;
        private int[] stats = new int[5];
        private string[] statsNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };

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

        private int[] Stats
        {
            get => this.stats;
            set
            {
                for (int i = 0; i < this.stats.Length; i++)
                {
                    if (value[i] < MIN_STAT_POINTS || value[i] > MAX_STAT_POINTS)
                    {
                        throw new ArgumentException($"{this.statsNames[i]} should be between {MIN_STAT_POINTS} and {MAX_STAT_POINTS}.");
                    }
                    this.stats[i] = value[i];
                }
            }
        }

        // Constructor.
        public Player(string name, int[] stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        // Methods.
        public double PlayerRating => CalculatePlayerRating();

        private double CalculatePlayerRating()
        {
            return this.stats.Sum() / 5.0;
        }
    }
}
