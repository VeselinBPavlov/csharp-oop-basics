namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<Person> persons;
        static List<string> relationships;

        public static void Main()
        {
            var personInfo = Console.ReadLine();
            persons = new List<Person>();
            relationships = new List<string>();

            // Get people and relationships.
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-") == false)
                {
                    AddMember(input);
                    continue;
                }

                relationships.Add(input);
            }

            // Get every person parents and children.
            foreach (var info in relationships)
            {
                var data = info.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                var parent = GetPerson(data[0]);
                var child = GetPerson(data[1]);

                if (parent.Children.Contains(child) == false)
                {
                    parent.Children.Add(child);
                }
                if (child.Parents.Contains(parent) == false)
                {
                    child.Parents.Add(parent);
                }                
            }

            // Print result.
            Print(personInfo);
        }

        private static void Print(string personInfo)
        {
            var mainPerson = GetPerson(personInfo);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.Birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }

        private static Person GetPerson(string input)
        {
            if (input.Contains("/"))
            {
                return persons.FirstOrDefault(x => x.Birthday == input);
            }

            return persons.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(string input)
        {
            var data = input.Split();
            var name = $"{data[0]} {data[1]}";
            var birthday = data[2];
            var person = new Person(name, birthday);
            persons.Add(person);
        }
    }
}
