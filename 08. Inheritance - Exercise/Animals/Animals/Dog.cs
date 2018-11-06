namespace Animals.Animals
{
    using System;

    public class Dog : Animal
    {
        // Constructor.
        public Dog(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        // Method.
        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
