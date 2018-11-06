namespace FoodShortage.Models
{
    using FoodShortage.Contracts;

    public class Rebel : Person, IBuyer
    {
        private const int increaseFood = 5;

        public string Group { get; }

        public Rebel(string name, int age, string group)
            : base(name, age)
        {
            Group = group;
        }

        public override void BuyFood()
        {
            Food += increaseFood;
        }
    }
}
