namespace Google
{
    public class Company
    {
        // Fileds.
        private string companyName;
        private string department;
        private string salary;

        // Properties.
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Department { get => department; set => department = value; }
        public string Salary { get => salary; set => salary = value; }

        // Constructor.
        public Company(string companyName, string department, string salary)
        {
            this.CompanyName = companyName;
            this.Department = department;
            this.Salary = salary;
        }

        public Company()
        {
        }

        // Methods.
        public override string ToString()
        {
            if (companyName == null)
            {
                return "";
            }
            return $"\n{this.companyName} {this.department} {decimal.Parse(this.salary):f2}";
        }
    }
}
