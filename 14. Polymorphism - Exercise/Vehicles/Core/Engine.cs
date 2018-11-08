namespace Vehicles.Core
{
    using System;
    using Vehicles.Contracts;
    using Vehicles.Models;

    public class Engine
    {
        public void Run()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();            

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);


            IVehicle car = new Car(carFuelQuantity, carFuelConsumption);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var actionsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < actionsCount; i++)
            {
                try
                {
                    var data = Console.ReadLine().Split();
                    var action = data[0];
                    var vehicleType = data[1];
                    var value = double.Parse(data[2]);

                    if (action == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }
                        else
                        {
                            truck.Refuel(value);
                        }
                    }
                    else
                    {
                        if (vehicleType == "Car")
                        {
                            car.Drive(value);
                        }
                        else
                        {
                            truck.Drive(value);
                        }
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);                    
                }                
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
