namespace WildFarm.Contracts.Animals
{
    using WildFarm.Contracts.Foods;

    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        void ProduceSound();
        void Eat(IFood food);
    }
}
