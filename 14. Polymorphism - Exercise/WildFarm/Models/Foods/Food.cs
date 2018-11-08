namespace WildFarm.Models.Foods
{
    using WildFarm.Contracts.Foods;

    public class Food : IFood
    {
        public int Quantity { get; protected set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
