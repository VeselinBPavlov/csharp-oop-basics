namespace Animals.Animals
{
    using System;

    public class Kitten : Cat
    {
        // Field.
        private const string gender = "Female";

        // Constructor.
        public Kitten(string name, int age) 
            : base(name, age, gender)
        {
        }

        // Method.
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
