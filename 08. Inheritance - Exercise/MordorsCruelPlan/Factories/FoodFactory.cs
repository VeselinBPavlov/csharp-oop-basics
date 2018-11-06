namespace MordorsCruelPlan.Factories
{
    using MordorsCruelPlan.Foods;

    public class FoodFactory
    {
        public Food CreateFood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "apple": return new Apple();
                case "cram": return new Cram();
                case "honeycake": return new HoneyCake();
                case "lembas": return new Lembas();
                case "melon": return new Melon();
                case "mushrooms": return new Mushroom();
                default: return new Junk();
            }
        }
    }
}
