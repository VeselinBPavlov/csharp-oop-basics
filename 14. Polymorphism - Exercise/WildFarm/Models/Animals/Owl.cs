namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Foods;
    using WildFarm.Models.Foods;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat == false)
            {
                base.WrongFood(food);
            }
            else
            {
                base.Eat(food);
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
