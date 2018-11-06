namespace Mankind
{
    using System;

    public class Worker : Human
    {
        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 12;
        private const decimal MINIMUM_SALARY = 10;
        private const int WORK_DAYS_IN_WEEK = 5;

        // Fields.
        private decimal weekSalary;
        private decimal workHoursPerDay;

        // Properties.
        public decimal WeekSalary
        {
            get => this.weekSalary;
            set
            {
                if (value < MINIMUM_SALARY)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            set
            {
                if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        // Inherit Constructor.
        public Worker(string firstname, string lastname, decimal weekSalary, decimal hoursPerDay)
            : base(firstname, lastname)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = hoursPerDay;
        }

        // Methods.
        private decimal SalaryPerHour()
        {
            var daySalary = WeekSalary / WORK_DAYS_IN_WEEK;
            var hourSalary = daySalary / WorkHoursPerDay;
            return hourSalary;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Week Salary: {WeekSalary:F2}\n" +
                $"Hours per day: {WorkHoursPerDay:F2}\n" +
                $"Salary per hour: {SalaryPerHour():F2}";
        }
    }
}
