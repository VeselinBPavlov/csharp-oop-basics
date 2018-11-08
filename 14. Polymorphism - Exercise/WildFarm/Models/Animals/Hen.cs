namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Foods;

    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            base.Eat(food);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
