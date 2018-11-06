namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public int CodeNumber { get; private set; }

        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {this.CodeNumber}";
        }
    }
}