namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var employeeCount = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            var departmentSalaries = new Dictionary<string, List<decimal>>();

            // Get all information for employees.
            for (int i = 0; i < employeeCount; i++)
            {
                var data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                var salary = decimal.Parse(data[1]);
                var position = data[2];
                var department = data[3];

                var employee = new Employee(name, salary, position, department);

                // Get all salaries by department.
                if (departmentSalaries.ContainsKey(department) == false)
                {
                    departmentSalaries[department] = new List<decimal>();
                }
                departmentSalaries[department].Add(salary);

                // Get optioal information.
                if (data.Length == 5)
                {
                    if (data[4].Contains('@'))
                    {
                        employee.Email = data[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(data[4]);
                    }
                }

                if (data.Length == 6)
                {
                    employee.Email = data[4];
                    employee.Age = int.Parse(data[5]);
                }

                // Add employee to roster.
                employees.Add(employee);
            }

            // Get highest salary department.
            var highestSalary = departmentSalaries
                .OrderByDescending(x => x.Value.Average())
                .First()
                .Key;

            // Print hiest department employees.
            Console.WriteLine($"Highest Average Salary: {highestSalary}");
            foreach (var employee in employees.Where(e => e.Department == highestSalary).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }
}
