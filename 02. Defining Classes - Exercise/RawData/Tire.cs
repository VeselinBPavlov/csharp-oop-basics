namespace RawData
{
    public class Tire
    {
        // Fields.
        private int age;
        private double pressure;

        // Properties.
        public int Age { get => this.age; set => this.age = value; }
        public double Pressure { get => this.pressure; set => this.pressure = value; }

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }
    }
}
