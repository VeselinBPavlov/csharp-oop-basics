namespace AnimalCentre.Models.Hotel
{
    using AnimalCentre.Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Hotel : IHotel
    {
        private const int maxCapacity = 10;

        private Dictionary<string, IAnimal> animals;
        private  int capacity;
       
        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
            this.capacity = maxCapacity;
        }
       
        public void Adopt(string animalName, string owner)
        {
            if (this.animals.ContainsKey(animalName))
            {
                IAnimal animal = this.animals[animalName];
                animal.IsAdopt = true;
                animal.Owner = owner;
                this.animals.Remove(animalName);
                capacity++;
            }
            else
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
        }



        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get => new ReadOnlyDictionary<string, IAnimal>(this.animals);
       
        }
        public void Accommodate(IAnimal animal)
        {
            if (capacity <= 0)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (!this.animals.ContainsKey(animal.Name))
            {
                this.animals[animal.Name] = animal;
                capacity--;
            }
            else
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }
        }
    }
}