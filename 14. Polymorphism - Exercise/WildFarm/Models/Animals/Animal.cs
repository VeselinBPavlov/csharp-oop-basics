namespace WildFarm.Models.Animals
{
    using System;
    using WildFarm.Contracts.Animals;
    using WildFarm.Contracts.Foods;
    using WildFarm.Structs;

    public abstract class Animal : IAnimal
    {
        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public abstract void ProduceSound();

        public virtual void Eat(IFood food)
        {
            this.FoodEaten += food.Quantity;
            var increaseWeight = FoodsRich.IncreaseWeight(this);
            this.Weight += food.Quantity * increaseWeight;
        }

        protected string WrongFood(IFood food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
