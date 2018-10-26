namespace AnimalFarm
{
    using System;

    public class Chiken
    {
        // Fields.
        private string name;
        private int age;

        // Properties.
        public string Name {
            get => this.name;
            set
            {
                if (value == null || value == "" || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        // Constructor.
        public Chiken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Methods.
        public double ProductPerDay => CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
