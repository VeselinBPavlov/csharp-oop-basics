namespace VehiclesExtension.Models
{
    using System;

    public class Bus : Vehicle
    {
        private const double EXTRA_CONSUMPTION = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentConsumption = this.Consumption;

            if (this.IsACOn == true)
            {
                currentConsumption += EXTRA_CONSUMPTION;
            }

            var neededFuel = distance * currentConsumption;

            if (this.Fuel < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.Fuel -= neededFuel;
        }
    }
}
