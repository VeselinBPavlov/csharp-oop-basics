namespace VehiclesExtension.Models
{
    using System;
    using VehiclesExtension.Contracts;

    public abstract class Vehicle : IVehicle
    {
        private double fuel;
        private double consumption;
        private double tankCapacity;
        private bool isACOn;

        public double Fuel
        {
            get => this.fuel;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }

                this.fuel = value;                
            }
        }

        public double Consumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public bool IsACOn { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.Fuel = fuelQuantity;
            this.Consumption = fuelConsumption;            
        }       

        public virtual void Drive(double distance)
        {
            var neededFuel = distance * this.Consumption;           

            if (this.Fuel < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");                              
            }

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.Fuel -= neededFuel;
        }

        public void Refuel(double quantity)
        {           

            if (quantity + this.Fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }


            if (this is Truck)
            {
                quantity *= 0.95;
            }

            this.Fuel += quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }
    }
}
