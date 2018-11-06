namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Enums;
    using System.Collections.Generic;

    public class Commando : SpecialisedSoldier, ICommando
    {

        public ICollection<IMission> Missions { get; set; }

        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}\nMissions:{(this.Missions.Count == 0 ? "" : "\n  ")}{string.Join("\n ", this.Missions)}";
        }
    }
}