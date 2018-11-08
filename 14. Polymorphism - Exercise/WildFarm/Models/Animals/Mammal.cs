namespace WildFarm.Models.Animals
{
    using WildFarm.Contracts.Animals;

    public abstract class Mammal : Animal, IMammal
    {
        public string LivingRegion { get; protected set; }

        public Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
