namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Enums;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public Corps Corps { get; set; }

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }      
    }
}