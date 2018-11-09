namespace StorageMaster.Models.Storage
{
    using StorageMaster.Models.Vehicles;

    public class DistributionCenter : Storage
    {
        private static readonly Vehicle[] DefaultVehicles =
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name) 
            : base(name, capacity: 2, garageSlots: 5, vehicles: DefaultVehicles)
        {
        }
    }
}
