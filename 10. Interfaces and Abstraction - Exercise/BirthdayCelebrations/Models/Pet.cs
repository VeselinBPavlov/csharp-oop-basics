namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Contracts;

    public class Pet : IBirthdateable
    {
        public string Name { get; private set; }
        public string Birthdate { get; private set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
