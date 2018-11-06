namespace Mankind
{
    using System;
    using System.Linq;

    public class Student : Human
    {
        private const int NUMBER_MIN_LENGTH = 5;
        private const int NUMBER_MAX_LENGTH = 10;

        // Field.
        private string facultyNumber;
        
        // Property.
        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length < NUMBER_MIN_LENGTH ||
                    value.Length > NUMBER_MAX_LENGTH ||
                    !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }
        
        // Inherit Constructor.
        public Student(string firstname, string lastname, string facultyNumber)
            : base(firstname, lastname)
        {
            this.FacultyNumber = facultyNumber;
        }

        // Method.
        public override string ToString()
        {
            return base.ToString() + $"Faculty number: {FacultyNumber}\n";
        }
    }
}