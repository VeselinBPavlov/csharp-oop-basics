namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        private const int MIN_AGE = 0;

        // Fields.
        private string name;
        private int age;

        // Properties.
        public virtual string Name { get => this.name;  set => this.name = value; }
        public virtual int Age
        {
            get => this.age;

            set
            {
                if (value < MIN_AGE)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        // Constructor.
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"Name: {this.Name}, Age: {this.Age}"));

            return stringBuilder.ToString();
        }
    }
}
