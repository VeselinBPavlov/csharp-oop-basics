namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Foods;
    using WildFarm.Models.Foods;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable == false && food is Fruit == false)
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
            Console.WriteLine("Squeak");
        }
    }
}
