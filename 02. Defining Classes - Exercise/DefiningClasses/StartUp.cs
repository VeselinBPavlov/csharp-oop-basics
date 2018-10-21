namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstPerson = new Person();
            var secondPerson = new Person();
            var thirdPerson = new Person();

            firstPerson.Name = "Pesho";
            firstPerson.Age = 20;
            secondPerson.Name = "Gosho";
            secondPerson.Age = 18;
            thirdPerson.Name = "Stamat";
            thirdPerson.Age = 43;

            Console.WriteLine($"My name is {firstPerson.Name} and I am {firstPerson.Age} years old.");
            Console.WriteLine($"My name is {secondPerson.Name} and I am {secondPerson.Age} years old.");
            Console.WriteLine($"My name is {thirdPerson.Name} and I am {thirdPerson.Age} years old.");
        }
    }
}
