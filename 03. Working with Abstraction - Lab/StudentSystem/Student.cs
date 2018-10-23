namespace StudentSystem
{
    public class Student
    {
        // Properties.
        public string Grade { get; set; }
        public string Age { get; set; }
        public string Name { get; set; }

        // Constructor.
        public Student(string name, string age, string grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}