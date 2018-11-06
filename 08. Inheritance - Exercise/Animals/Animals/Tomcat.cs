namespace Animals.Animals
{
    using System;

    public class Tomcat : Cat
    {
        // Field.
        private const string gender = "Male";

        // Constructor.
        public Tomcat(string name, int age) 
            : base(name, age, gender)
        {           
        }

        // Method.
        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
