namespace FoodShortage.Models
{
    using FoodShortage.Contracts;

    public class Citizen : Person
    {
        private const int increaseFood = 10;

        public string Id { get; }
        public string Birthdate { get; }

        public Citizen(string name, int age, string id, string birthdate)
            : base(name, age)
        {
            Id = id;
            Birthdate = birthdate;
        }

        public override void BuyFood()
        {
            Food += increaseFood;
        }
    }
}
