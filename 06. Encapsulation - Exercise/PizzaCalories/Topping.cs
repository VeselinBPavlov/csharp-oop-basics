namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const int BASE_CALORIES = 2;
        private const double MAX_WEIGHT = 50;
        private const double MIN_WEIGHT = 1;

        // Fields.
        private string type;
        private double weight;
        private Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            { "meat",  1.2 },
            { "veggies",  0.8 },
            { "cheese",  1.1 },
            { "sauce",  0.9 }
        };

        // Properties.
        private string Type
        {
            get => this.type;
            set
            {
                if (this.modifiers.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private double Weight
        {
            get => this.weight;
            set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }

        // Constructor.
        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        // Methods.
        private double CalculateCalories()
        {
            return (BASE_CALORIES * this.weight) * this.modifiers[this.type.ToLower()];
        }

        public double GetToppingCalories => CalculateCalories();
    }
}
