using System.Linq;

namespace RawData
{
    public class Car
    {
        // Fields.
        private Model model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        // Properties.
        public Model Model { get => this.model; set => this.model = value; }
        public Engine Engine { get => this.engine; set => this.engine = value; }
        public Cargo Cargo { get => this.cargo; set => this.cargo = value; }
        public Tire[] Tires { get => this.tires; set => this.tires = value; }

        // Constructor.
        public Car (Model model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = new Tire[4];            
        }

        // Methods.
        public override string ToString()
        {
            return $"{this.model.Name}";
        }
    }
}
