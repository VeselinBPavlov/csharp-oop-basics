﻿namespace AnimalCentre.Models.Services.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class DentalCare : Procedure
    {
        private const int AddHappiness = 12;
        private const int AddEnergy = 10;
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.CheckTime(procedureTime, animal);
            animal.Energy += AddEnergy;
            animal.Happiness += AddHappiness;
            base.procedureHistory.Add(animal);
        }
    }
}
