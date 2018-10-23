namespace PersonsInfo
{
    public class Person
    {
        // Fields.
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        // Auto properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        // Constructor.
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        // Methods.
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
