namespace CarSalesman
{
    public class Engine
    {
        // Fields.
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        // Properties.
        public string Model { get => this.model; set => this.model = value; }
        public int Power { get => this.power; set => this.power = value; }
        public string Displacement { get => this.displacement; set => this.displacement = value; }
        public string Efficiency { get => this.efficiency; set => this.efficiency = value; }

        // Constructor.
        public Engine (string model, int power, string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
