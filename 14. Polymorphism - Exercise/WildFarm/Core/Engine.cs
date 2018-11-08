namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Contracts.Animals;
    using WildFarm.Contracts.Foods;
    using WildFarm.Factories;

    public class Engine
    {        
        private AnimalFactory animalFactory;
        private FoodFactory foodFactory;
        private ICollection<IAnimal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<IAnimal>();
        }

        public object IAniml { get; private set; }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var animalData = command.Split();
                var foodData = Console.ReadLine().Split();

                IAnimal animal = animalFactory.CreateAnimal(animalData);
                IFood food = foodFactory.CreateFood(foodData[0], int.Parse(foodData[1]));

                animal.ProduceSound();
                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
