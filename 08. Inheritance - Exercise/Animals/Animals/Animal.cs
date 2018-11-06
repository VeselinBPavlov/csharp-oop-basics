namespace Animals.Animals
{
    using System;

    public abstract class Animal
    {
        // Fields.
        private string name;
        private int age;
        private string gender;

        // Properties.
        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid input!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;
            private set
            {
                if (value == null || String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid input!");
                }

                this.gender = value;
            }
        }

        // Constructor.
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        // Method.
        public virtual void ProduceSound()
        {
            Console.WriteLine("Shhht");
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
