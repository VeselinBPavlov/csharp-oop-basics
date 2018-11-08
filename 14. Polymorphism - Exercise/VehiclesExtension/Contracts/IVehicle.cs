namespace VehiclesExtension.Contracts
{
    public interface IVehicle
    {
        double Fuel { get; }
        double Consumption { get; }
        double TankCapacity { get; }
        bool IsACOn { get; set; }

        void Drive(double distance);
        void Refuel(double quantity);
    }
}
