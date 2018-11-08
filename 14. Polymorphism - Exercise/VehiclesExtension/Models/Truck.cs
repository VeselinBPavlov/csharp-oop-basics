namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double EXTRA_CONSUMPTION = 1.6;

        public Truck(double fuel, double consumption, double tankCapacity) 
            : base(fuel, consumption, tankCapacity)
        {
            this.Consumption += EXTRA_CONSUMPTION;
        }
    }
}
