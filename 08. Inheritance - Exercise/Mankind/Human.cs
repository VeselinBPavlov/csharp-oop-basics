namespace Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private const int FIRSTNAME_MIN_LENGTH = 4;
        private const int LASTNAME_MIN_LENGTH = 3;

        // Fields.
        private string firstName;
        private string lastName;

        // Properties.
        public string FirstName
        {
            get => this.firstName;
            set
            {
                Validator(value, FIRSTNAME_MIN_LENGTH, "firstName");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                Validator(value, LASTNAME_MIN_LENGTH, "lastName");
                this.lastName = value;
            }
        }

        // Constructor.
        public Human(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        // Methods.
        private void Validator(string value, int minLegth, string namePosition)
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {namePosition}");
            }
            else if (value.Length < minLegth)
            {
                throw new ArgumentException($"Expected length at least {minLegth} symbols! Argument: {namePosition}");
            }
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\n";
        }
    }
}
