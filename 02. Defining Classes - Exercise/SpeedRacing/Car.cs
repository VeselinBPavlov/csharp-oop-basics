namespace SpeedRacing
{
    using System;

    public class Car
    {
        // Fields.
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int traveledDistance;

        // Properties.
        public string Model { get => this.model; set => this.model = value; }
        public decimal FuelAmount { get => this.fuelAmount; set => this.fuelAmount = value; }
        public decimal FuelConsumption { get => this.fuelConsumption; set => this.fuelConsumption = value; }
        public int TraveledDistance { get => this.traveledDistance; set => this.traveledDistance = value; }

        // Constructor.
        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.TraveledDistance = 0;
        }

        // Methods.
        public void CalculateFuelAmount(int travelingDistance)
        {
            var neededFuelAmount = travelingDistance * this.fuelConsumption;

            if (this.fuelAmount >= neededFuelAmount)
            {
                this.FuelAmount -= neededFuelAmount;
                this.TraveledDistance += travelingDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.traveledDistance}";
        }
    }
}
