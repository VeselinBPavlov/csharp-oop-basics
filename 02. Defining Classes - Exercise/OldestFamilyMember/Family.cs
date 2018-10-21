namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        // Field.
        private List<Person> people;

        // Properties.
        public List<Person> People { get => this.people; set => this.people = value; }

        // Constructor.
        public Family()
        {
            this.People = new List<Person>();
        }

        // Methods.
        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestPerson = this.People.OrderByDescending(x => x.Age).First();
            return oldestPerson;
        }
    }
}
