namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const double MIN_WEIGHT = 1;
        private const double MAX_WEIGHT = 200;
        private const double BASE_CALORIES = 2;

        // Fields.
        private string type;
        private string tehnique;
        private double weight;
        private Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            { "white",  1.5 },
            { "wholegrain",  1.0 },
            { "crispy",  0.9 },
            { "chewy",  1.1 },
            { "homemade",  1.0 }
        };

        // Properties.
        private string Type
        {
            get => this.type;
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.type = value;
            }
        }

        private string Tehnique
        {
            get => this.tehnique;
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.tehnique = value;
            }
        }
        private double Weight
        {
            get => this.weight;
            set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }        

        // Constructor.
        public Dough(string type, string tehnique, double weigth)
        {
            this.Type = type;
            this.Tehnique = tehnique;
            this.Weight = weigth;
        }

        // Methods.
        private double CalculateCalories()
        {
            return (BASE_CALORIES * this.weight) * this.modifiers[this.type.ToLower()] * modifiers[this.tehnique.ToLower()];
        }

        public double GetDoughCalories => CalculateCalories();
    }
}
