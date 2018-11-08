namespace VehiclesExtension.Core
{
    using System;
    using VehiclesExtension.Contracts;
    using VehiclesExtension.Models;

    public class Engine
    {
        public void Run()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carFuelConsumption = double.Parse(carInfo[2]);
            var carTankCapacity = double.Parse(carInfo[3]);

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckFuelConsumption = double.Parse(truckInfo[2]);
            var truckTankCapacity = double.Parse(truckInfo[3]);

            var busFuelQuantity = double.Parse(busInfo[1]);
            var busFuelConsumption = double.Parse(busInfo[2]);
            var busTankCapacity = double.Parse(busInfo[3]);
            
            IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);                       

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
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }
                        else
                        {
                            bus.Refuel(value);
                        }
                    }
                    else if (action == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Drive(value);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(value);
                        }
                        else
                        {
                            bus.IsACOn = true;
                            bus.Drive(value);
                        }
                    }
                    else
                    {
                        bus.IsACOn = false;
                        bus.Drive(value);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}

