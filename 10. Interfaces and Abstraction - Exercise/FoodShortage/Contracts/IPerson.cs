namespace FoodShortage.Contracts
{
    public interface IPerson : IBuyer
    {
        string Name { get; }
        int Age { get; }
    }
}
