﻿namespace WildFarm.Structs
{
    using System;
    using WildFarm.Contracts.Animals;

    public static class FoodsRich
    {
        public static double IncreaseWeight(IAnimal animal)
        {
            switch (animal.GetType().Name)
            {
                case "Hen": return 0.35;
                case "Owl": return 0.25;
                case "Mouse": return 0.10;
                case "Cat": return 0.30;
                case "Dog": return 0.40;
                case "Tiger": return 1.00;
                default: throw new ArgumentException("Current Animal Type Is Not Valid!");
            }
        }
    }
}