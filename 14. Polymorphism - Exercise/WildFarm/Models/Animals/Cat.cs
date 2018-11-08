namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Foods;
    using WildFarm.Models.Foods;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable == false && food is Meat == false)
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
            Console.WriteLine("Meow");
        }
    }
}
