namespace WildFarm.Factories
{
    using System;
    using WildFarm.Contracts.Foods;
    using WildFarm.Models.Foods;

    public class FoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            type = type.ToLower();

            switch (type)
            {
                case "vegetable": return new Vegetable(quantity);
                case "fruit": return new Fruit(quantity);
                case "meat": return new Meat(quantity);
                case "seeds": return new Seeds(quantity);
                default: throw new ArgumentException("Ivalid input!");
            }
        }
    }
}
