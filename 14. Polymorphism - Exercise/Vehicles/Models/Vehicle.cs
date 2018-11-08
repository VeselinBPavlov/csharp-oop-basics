namespace Vehicles.Models
{
    using System;
    using Vehicles.Contracts;

    public abstract class Vehicle : IVehicle
    {
        private double fuel;
        private double consuption;

        public double Fuel { get; protected set; }
        public double Consumption { get; protected set; }

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.Fuel = fuelQuantity;
            this.Consumption = fuelConsumption;
        }       

        public void Drive(double distance)
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
