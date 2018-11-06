namespace Animals.Animals
{
    using System;

    public class Cat : Animal
    {
        // Constructor.
        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }
        
        // Method.
        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
