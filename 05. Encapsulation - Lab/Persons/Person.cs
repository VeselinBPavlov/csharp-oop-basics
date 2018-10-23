namespace PersonsInfo
{
    public class Person
    {
        // Fields.
        private string firstName;
        private string lastName;
        private int age;

        // Auto properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor.
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        // Method.
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
