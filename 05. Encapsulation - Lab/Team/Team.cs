namespace PersonsInfo
{
    using System.Collections.Generic;

    public class Team
    {
        // Fields.
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        // Properties.
        public IReadOnlyCollection<Person> FirstTeam
        {
            get => this.firstTeam;
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get => this.reserveTeam;
        }

        // Constructor.
        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        // Method.
        public void AddPlayer(Person person)
        {
            if (person.Age >= 40)
            {
                reserveTeam.Add(person);
            }
            else
            {
                firstTeam.Add(person);
            }
        }
    }
}

