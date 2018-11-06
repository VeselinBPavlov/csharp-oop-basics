namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using System.Collections.Generic;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        // TOOD: Add readonly collection.
        public ICollection<IPrivate> Privates { get; set; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:{(this.Privates.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", this.Privates)}";
        }
    }
}