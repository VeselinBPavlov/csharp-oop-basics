﻿namespace DefiningClasses
{
    public class Person
    {
        // Fields.
        private string name;
        private int age;

        // Properties.
        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }

        // Constructors.
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}