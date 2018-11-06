namespace BirthdayCelebrations.Core
{
    using BirthdayCelebrations.Contracts;
    using BirthdayCelebrations.Models;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private ICollection<IBirthdateable> creatures;

        public Engine()
        {
            this.creatures = new List<IBirthdateable>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();

                var type = input[0].ToLower();

                switch (type)
                {
                    case "citizen":
                        {
                            var name = input[1];
                            var age = int.Parse(input[2]);
                            var id = input[3];
                            var birthdate = input[4];
                            IBirthdateable citizen = new Citizen(name, age, id, birthdate);
                            creatures.Add(citizen);
                        }
                        break;
                    case "pet":
                        {
                            var name = input[1];
                            var birthdate = input[2];
                            IBirthdateable pet = new Pet(name, birthdate);
                            creatures.Add(pet);
                        }
                        break;
                    case "robot": break;
                    default: break;
                }                
            }

            var birthdateToFind = Console.ReadLine();

            foreach (var creature in creatures)
            {
                if (creature.Birthdate.EndsWith(birthdateToFind))
                {
                    Console.WriteLine(creature.Birthdate);
                }
            }
        }
    }
}
