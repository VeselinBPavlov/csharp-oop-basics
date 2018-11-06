namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;

    public class Private : Soldier, IPrivate
    {        
        private decimal salary;

        // TODO: Add validation.
        public decimal Salary { get => salary; private set => salary = value; }
        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:F2}";
        }
    }
}