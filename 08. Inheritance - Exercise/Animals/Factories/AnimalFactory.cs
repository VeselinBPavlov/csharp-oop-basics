﻿using Animals.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Core
{
    public class AnimalFactory
    {
        // Create animal method.
        public Animal CreateAnimal(string type, string name, int age, string gender)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cat": return new Cat(name, age, gender);
                case "dog": return new Dog(name, age, gender);
                case "frog": return new Frog(name, age, gender);
                case "kitten": return new Kitten(name, age);
                case "tomcat": return new Tomcat(name, age);
                default: throw new Exception("Invalid input!");
            }
        }
    }
}
