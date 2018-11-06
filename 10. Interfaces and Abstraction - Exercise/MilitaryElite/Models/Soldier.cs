namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;

    public abstract class Soldier : ISoldier
    {
        private int id;
        private string firstName;
        private string lastName;

        //TODO: Add validation.
        public int Id { get => id; private set => id = value; }
        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }

        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} ";
        }
    }
}