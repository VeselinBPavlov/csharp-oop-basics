namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var family = new Family();

            // Create a family.
            for (int i = 0; i < peopleCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var age = int.Parse(data[1]);

                var person = new Person(name, age);

                family.AddMember(person);
            }

            // Print oldest member.
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
