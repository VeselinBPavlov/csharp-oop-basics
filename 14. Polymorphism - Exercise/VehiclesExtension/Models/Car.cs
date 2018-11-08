namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double EXTRA_CONSUMPTION = 0.9;

        public Car(double fuel, double consumption, double tankCapacity) 
            : base(fuel, consumption, tankCapacity)
        {
            this.Consumption += EXTRA_CONSUMPTION;
        }
    }
}
