namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double EXTRA_CONSUMPTION = 1.6;

        public Truck(double fuel, double consumption) 
            : base(fuel, consumption)
        {
            this.Consumption += EXTRA_CONSUMPTION;
        }
    }
}
