namespace PersonsInfo
{
    using System;

    public class Person
    {
        // Fields.
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        // Auto properties.
        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
         }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

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
            return $"{this.FirstName} {this.LastName} gets {this.Salary:f2} leva.";
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