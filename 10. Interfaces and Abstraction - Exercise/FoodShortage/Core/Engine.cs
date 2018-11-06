namespace FoodShortage.Core
{
    using FoodShortage.Contracts;
    using FoodShortage.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        ICollection<IPerson> people;

        public Engine()
        {
            this.people = new List<IPerson>();
        }

        public void Run()
        {
            var peopleCount = int.Parse(Console.ReadLine());

            GetAllPeople(peopleCount);

            CalculateTotalFood();

        }

        private void CalculateTotalFood()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var name = command;
                var person = people.FirstOrDefault(p => p.Name == name);

                if (person != null)
                {
                    person.BuyFood();
                }
            }

            Console.WriteLine(people.Sum(p => p.Food));
        }

        private void GetAllPeople(int peopleCount)
        {
            for (int i = 0; i < peopleCount; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    var id = input[2];
                    var birthdate = input[3];

                    IPerson citizen = new Citizen(name, age, id, birthdate);
                    people.Add(citizen);
                }

                if (input.Length == 3)
                {
                    var group = input[2];
                    IPerson rebel = new Rebel(name, age, group);
                    people.Add(rebel);
                }
            }
        }
    }
}
