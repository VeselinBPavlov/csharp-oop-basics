namespace DefiningClasses
{
    public class Person
    {
        // Fields.
        private string name;
        private int age;

        // Properties.
        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }
    }
}
