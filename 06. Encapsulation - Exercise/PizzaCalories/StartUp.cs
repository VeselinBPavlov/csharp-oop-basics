namespace PizzaCalories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Pizza pizza = null;

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] data = input
                        .Split(' ');
                    string command = data[0];

                    switch (command)
                    {
                        case "Pizza":
                            string pizzaName = data[1];
                            pizza = new Pizza(pizzaName);
                            break;
                        case "Dough":
                            string flourType = data[1];
                            string bakingTechnique = data[2];
                            double doughWeight = double.Parse(data[3]);

                            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
                            pizza.AddDough(dough);
                            break;
                        case "Topping":
                            string toppingType = data[1];
                            double toppingWeight = double.Parse(data[2]);

                            Topping topping = new Topping(toppingType, toppingWeight);
                            pizza.AddTopping(topping);
                            break;
                    }
                }
                
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
