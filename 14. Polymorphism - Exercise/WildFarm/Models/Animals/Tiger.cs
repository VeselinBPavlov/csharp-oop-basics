namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Foods;
    using WildFarm.Models.Foods;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
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
            Console.WriteLine("ROAR!!!");
        }
    }
}
