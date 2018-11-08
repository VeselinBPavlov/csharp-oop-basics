namespace WildFarm.Models.Animals
{
    using WildFarm.Contracts.Animals;

    public abstract class Bird : Animal, IBird
    {
        public double WingSize { get; protected set; }

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
