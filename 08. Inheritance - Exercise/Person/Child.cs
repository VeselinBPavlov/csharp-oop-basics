namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Child : Person
    {
        private const int MIN_LENGTH = 3;
        private const int MAX_AGE = 15;

        // Properties.
        public override string Name
        {
            get => base.Name;
            set
            {
                if (value.Length < MIN_LENGTH)
                {
                    throw new ArgumentException($"Name's length should not be less than {MIN_LENGTH} symbols!");
                }
                base.Name = value;
            }
        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if (value > MAX_AGE)
                {
                    throw new ArgumentException($"Child's age must be less than {MAX_AGE}!");
                }
                base.Age = value;
            }
        }

        // Inherit contstructor.
        public Child(string name, int age) : base(name, age)
        {
        }
    }
}
