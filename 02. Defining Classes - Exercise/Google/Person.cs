namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        // Fields.
        private string name;
        private Company company;
        private List<Pokemon> pokemons;
        private List<Parent> parents;
        private List<Child> children;
        private Car car;

        // Properties.
        public string Name { get => name; set => name = value; }
        public Company Company { get => company; set => company = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        public List<Parent> Parents { get => parents; set => parents = value; }
        public List<Child> Children { get => children; set => children = value; }
        public Car Car { get => car; set => car = value; }

        // Constructor.
        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Car = new Car();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }

        // Methods.
        public override string ToString()
        {
            var print = "";
            print += $"{this.name}";
            print += $"\nCompany: {this.company}";
            print += $"\nCar: {this.car}";
            print += $"\nPokemon:{string.Join("", this.pokemons.Select(p => $"\n{p.PokemonName} {p.PokemonType}"))}";
            print += $"\nParents:{string.Join("", this.Parents.Select(p => $"\n{p.ParentName} {p.ParentBirthday}"))}";
            print += $"\nChildren:{string.Join("", this.Children.Select(p => $"\n{p.ChildName} {p.ChildBirthday}"))}";           

            return print;
        }
    }
}
