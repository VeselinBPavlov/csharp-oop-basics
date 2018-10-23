namespace StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static Dictionary<string, Student> students;

        public static void Main()
        {
            students = new Dictionary<string, Student>();

            string command;
            while ((command = Console.ReadLine()) != "Exit")
            {
                var args = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (args[0] == "Create")
                {
                    CreateStudent(args);
                }
                else if (args[0] == "Show")
                {
                    ShowStudent(args);
                }
            }
        }

        private static void CreateStudent(string[] args)
        {
            var name = args[1];
            var age = args[2];
            var grade = args[3];
            if (!students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                students[name] = student;
            }
        }

        private static void ShowStudent(string[] args)
        {
            var name = args[1];
            if (students.ContainsKey(name))
            {
                var student = students[name];
                string view = $"{student.Name} is {student.Age} years old.";

                if (double.Parse(student.Grade.ToString()) >= 5.00)
                {
                    view += " Excellent student.";
                }
                else if (double.Parse(student.Grade.ToString()) < 5.00 && double.Parse(student.Grade.ToString()) >= 3.50)
                {
                    view += " Average student.";
                }
                else
                {
                    view += " Very nice person.";
                }

                Console.WriteLine(view);
            }
        }
    }
}
