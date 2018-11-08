namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double EXTRA_CONSUMPTION = 0.9;

        public Car(double fuel, double consumption) 
            : base(fuel, consumption)
        {
            this.Consumption += EXTRA_CONSUMPTION;
        }
    }
}
