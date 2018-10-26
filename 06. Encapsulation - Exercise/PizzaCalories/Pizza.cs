namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const int MIN_LENGHT_NAME = 1;
        private const int MAX_LENGHT_NAME = 15;
        private const int MAX_COUNT_TOPPINGS = 10;
        private const int MIN_COUNT_TOPPINGS = 0;

        // Fields.
        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        // Properties.
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > MAX_LENGHT_NAME)
                {
                    throw new ArgumentException($"Pizza name should be between {MIN_LENGHT_NAME} and {MAX_LENGHT_NAME} symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get => this.dough;
            private set => this.dough = value;
        }

        // Constructor.
        public Pizza(string name)
        {
            this.Name = name;
        }

        // Methods.
        public void AddDough(Dough dough) => this.Dough = dough;

        public double TotalCalories => CalculateTotalCalories();

        private double CalculateTotalCalories()
        {
            return this.dough.GetDoughCalories + this.toppings.Sum(t => t.GetToppingCalories);
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count > MAX_COUNT_TOPPINGS || this.toppings.Count < MIN_COUNT_TOPPINGS)
            {
                throw new ArgumentException($"Number of toppings should be in range [{MIN_COUNT_TOPPINGS}..{MAX_COUNT_TOPPINGS}].");
            }
            else
            {
                this.toppings.Add(topping);
            }
        }
    }
}
