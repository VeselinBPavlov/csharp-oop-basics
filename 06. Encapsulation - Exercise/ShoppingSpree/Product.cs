namespace ShoppingSpree
{
    using System;

    public class Product
    {
        // Fields.
        private string name;
        private decimal cost;

        // Properties.
        public string Name
        {
            get => this.name;
            private set
            {
                if (value == null || value == "" || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        // Constructor.
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
