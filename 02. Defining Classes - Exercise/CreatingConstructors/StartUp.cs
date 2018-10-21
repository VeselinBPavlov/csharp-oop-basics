namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstPerson = new Person();
            var secondPerson = new Person(18);
            var thirdPerson = new Person("Pesho", 13);

            Console.WriteLine($"My name is {firstPerson.Name} and I am {firstPerson.Age} years old.");
            Console.WriteLine($"My name is {secondPerson.Name} and I am {secondPerson.Age} years old.");
            Console.WriteLine($"My name is {thirdPerson.Name} and I am {thirdPerson.Age} years old.");
        }
    }
}
