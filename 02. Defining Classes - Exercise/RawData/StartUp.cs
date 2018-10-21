namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            // Get all cars.
            for (int i = 0; i < carsCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = new Model(data[0]);
                var engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
                var cargo = new Cargo(int.Parse(data[3]), data[4]);
                var tires = new Tire[4];
                tires[0] = new Tire(double.Parse(data[5]), int.Parse(data[6]));
                tires[1] = new Tire(double.Parse(data[7]), int.Parse(data[8]));
                tires[2] = new Tire(double.Parse(data[9]), int.Parse(data[10]));
                tires[3] = new Tire(double.Parse(data[11]), int.Parse(data[12]));

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var cargoType = Console.ReadLine();

            // Print cars depending of cargo type.
            if (cargoType == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .ToList().ForEach(c => Console.WriteLine(c));
            }
            else
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList().ForEach(c => Console.WriteLine(c));
            }
        }
    }
}

