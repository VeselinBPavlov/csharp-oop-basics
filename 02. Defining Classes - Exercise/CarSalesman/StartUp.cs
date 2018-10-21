namespace CarSalesman
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var enginesCount = int.Parse(Console.ReadLine());
            var engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            // Get all engine models.
            for (int i = 0; i < enginesCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var engineModel = data[0];
                var enginePower = int.Parse(data[1]);
                
                if (engines.ContainsKey(engineModel) == false)
                {
                    engines[engineModel] = new Engine(engineModel, enginePower, "n/a", "n/a");
                }

                if (data.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(data[2], out displacement))
                    {
                        engines[engineModel].Displacement = data[2];
                    }
                    else
                    {
                        engines[engineModel].Efficiency = data[2];
                    }
                }

                if (data.Length == 4)
                {
                    engines[engineModel].Displacement = data[2];
                    engines[engineModel].Efficiency = data[3];
                }
            }

            var carsCount = int.Parse(Console.ReadLine());

            // Get all cars with full engine information.
            for (int i = 0; i < carsCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var carModel = data[0];
                var engine = engines[data[1]];

                var car = new Car(carModel, engine, "n/a", "n/a");

                if (data.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(data[2], out displacement))
                    {
                        car.Weight = data[2];
                    }
                    else
                    {
                        car.Color = data[2];
                    }
                }

                if (data.Length == 4)
                {
                    car.Weight = data[2];
                    car.Color = data[3];
                }

                cars.Add(car);
            }

            // Print all cars.
            Console.WriteLine(String.Join(Environment.NewLine, cars));
        }
    }
}
