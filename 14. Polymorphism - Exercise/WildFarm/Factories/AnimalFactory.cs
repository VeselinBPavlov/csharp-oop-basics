using System;
using WildFarm.Contracts.Animals;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public IAnimal CreateAnimal(string []input)
        {
            var type = input[0].ToLower();

            switch (type)
            {
                case "cat": return new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                case "tiger": return new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                case "mouse": return new Mouse(input[1], double.Parse(input[2]), input[3]);
                case "dog": return new Dog(input[1], double.Parse(input[2]), input[3]);
                case "owl": return new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                case "hen": return new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                default: throw new ArgumentException("Ivalid input!");
            }
        }
    }
}
