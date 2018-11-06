namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Enums;
    using System.Collections.Generic;

    public class Engineer : SpecialisedSoldier, IEngineer

    {
        public ICollection<IRepair> Repairs { get ; set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}\nRepairs:{(this.Repairs.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", this.Repairs)}";
        }
    }
}