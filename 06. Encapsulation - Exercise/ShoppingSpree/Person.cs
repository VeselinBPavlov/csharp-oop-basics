namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        // Fields.
        private string name;
        private decimal money;
        private List<Product> products = new List<Product>();

        // Properties.
        public string Name
        {
            get => this.name;
            set
            {
                if (value == null || value == "" || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        private decimal Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        // Constructor.
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        // Methods.
        public void BuyProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                this.products.Add(product);
                Console.WriteLine($"{this.name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            var print = "";
            print += $"{this.name} - ";

            if (this.products.Count != 0)
            {
                print += $"{string.Join(", ", products.Select(x => x.Name))}";
            }
            else
            {
                print += "Nothing bought";
            }
            return print;
        }
    }
}
