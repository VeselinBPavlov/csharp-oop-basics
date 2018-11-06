namespace BorderControl.Core
{
    using BorderControl.Contracts;
    using BorderControl.Models;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private ICollection<IIdentifiable> creatures;

        public Engine()
        {
            this.creatures = new List<IIdentifiable>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();

                if (input.Length == 3)
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var id = input[2];

                    IIdentifiable citizen = new Citizen(name, age, id);
                    creatures.Add(citizen);
                }

                if (input.Length == 2)
                {
                    var name = input[0];
                    var id = input[1];

                    IIdentifiable robot = new Robot(name, id);
                    creatures.Add(robot);
                }
            }

            var invalidNumber = Console.ReadLine();

            foreach (var creture in creatures)
            {
                if (creture.Id.EndsWith(invalidNumber))
                {
                    Console.WriteLine(creture.Id);
                }
            }
        }
    }
}
