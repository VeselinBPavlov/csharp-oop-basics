namespace Animals.Core
{
    using global::Animals.Animals;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        // Work with animal factory.
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
        }

        // Main logic.
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    var type = command;
                    var data = Console.ReadLine().Split();
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];

                    var animal = animalFactory.CreateAnimal(type, name, age, gender);
                    animals.Add(animal);                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }

            Print();
        }

        private void Print()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
