namespace CarSalesman
{
    public class Car
    {
        // Fields.
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        // Properties.
        public string Model { get => this.model; set => this.model = value; }
        public Engine Engine { get => this.Engine; set => this.engine = value; }
        public string Weight { get => this.weight; set => this.weight = value; }
        public string Color { get => this.color; set => this.color = value; }

        // Constructor.
        public Car (string model, Engine engine, string weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        // Methods.
        public override string ToString()
        { 
            var print = "";
            print += $"{this.model}:\n";
            print += $"  {this.engine.Model}:\n";
            print += $"    Power: {this.engine.Power}\n";
            print += $"    Displacement: {this.engine.Displacement}\n";
            print += $"    Efficiency: {this.engine.Efficiency}\n";
            print += $"  Weight: {this.weight}\n";
            print += $"  Color: {this.color}";

            return print;
        }
    }
}
