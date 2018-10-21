namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            // Get all cars.
            for (int i = 0; i < carsCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = data[0];
                var fuelAmount = decimal.Parse(data[1]);
                var fuelConsumption = decimal.Parse(data[2]);

                var car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            // Calculate cars travelling distance.
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = data[1];
                var travellingDistance = int.Parse(data[2]);

                var index = cars.IndexOf(cars.Where(c => c.Model == model).First());
                var car = cars[index];
                car.CalculateFuelAmount(travellingDistance);

                cars[index] = car;
            }

            // Print all cars.
            Console.WriteLine(String.Join(Environment.NewLine, cars));
        }
    }
}
