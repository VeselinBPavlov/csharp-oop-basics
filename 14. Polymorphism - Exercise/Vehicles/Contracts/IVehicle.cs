namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        double Fuel { get; }
        double Consumption { get; }

        void Drive(double distance);
        void Refuel(double quantity);
    }
}
