namespace FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        // Fields.
        private string name;
        private string birthday;
        private List<Person> parents;
        private List<Person> children;

        // Properties.
        public string Name { get => this.name; set => this.name = value; }
        public string Birthday { get => this.birthday; set => this.birthday = value; }
        public List<Person> Parents { get => this.parents; set => this.parents = value; }
        public List<Person> Children { get => this.children; set => this.children = value; }

        // Constructor.
        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }
    }
}
