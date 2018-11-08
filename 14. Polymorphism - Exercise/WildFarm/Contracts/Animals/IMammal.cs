namespace WildFarm.Contracts.Animals
{
    public interface IMammal : IAnimal
    {
        string LivingRegion { get; }
    }
}
