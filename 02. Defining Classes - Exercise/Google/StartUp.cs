namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            // Create list of people with their info.
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var prop = data[1];

                var person = new Person(name);
                people.Add(person);

                switch (prop)
                {
                    case "company":
                        {
                            var companyName = data[2];
                            var departament = data[3];
                            var salary = data[4];
                            var company = new Company(companyName, departament, salary);
                            people.FirstOrDefault(x => x.Name == name).Company = company;
                        }
                        break;
                    case "car":
                        {
                            var carModel = data[2];
                            var carSpeed = data[3];
                            var car = new Car(carModel, carSpeed);
                            people.FirstOrDefault(x => x.Name == name).Car = car;
                        }
                        break;
                    case "pokemon":
                        {
                            var pokemonName = data[2];
                            var pokemonType = data[3];
                            var pokemon = new Pokemon(pokemonName, pokemonType);
                            people.FirstOrDefault(x => x.Name == name).Pokemons.Add(pokemon);
                        }
                        break;
                    case "parents":
                        {
                            var parentName = data[2];
                            var parentBirthday = data[3];
                            var parent = new Parent(parentName, parentBirthday);
                            people.FirstOrDefault(x => x.Name == name).Parents.Add(parent);
                        }
                        break;
                    case "children":
                        {
                            var childName = data[2];
                            var childBirthday = data[3];
                            var child = new Child(childName, childBirthday);
                            people.FirstOrDefault(x => x.Name == name).Children.Add(child);
                        }
                        break;
                    default: break;
                }
            }

            // Print person.
            var personToPrint = Console.ReadLine();
            Console.WriteLine(people.FirstOrDefault(p => p.Name == personToPrint));
        }
    }
}
