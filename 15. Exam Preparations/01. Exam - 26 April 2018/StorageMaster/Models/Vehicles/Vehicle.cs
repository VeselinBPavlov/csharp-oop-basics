namespace StorageMaster.Models.Vehicles
{
    using StorageMaster.Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Vehicle 
    {
        // Fields.
        private readonly List<Product> trunk;

        // Properties.
        public int Capacity { get; }
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        public bool IsFull => this.Trunk.Sum(c => c.Weight) >= this.Capacity;
        public bool IsEmpty => !this.Trunk.Any();

        // Constructor.
        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;

            this.trunk = new List<Product>();
        }

        // Methods.
        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (!this.trunk.Any())
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            var product = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }
    }
}
