namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            // Make list of persons.
            for (int i = 0; i < peopleCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var age = int.Parse(data[1]);
                var person = new Person(name, age);
                people.Add(person);
            }

            // Print people over 30 years old.
            people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
