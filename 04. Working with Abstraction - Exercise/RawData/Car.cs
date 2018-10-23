﻿using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, Tire[] tires)
        {
            this.Model = model;
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
            this.Tires = tires;
        }
   
    }
}
