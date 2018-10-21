namespace RawData
{
    public class Cargo
    {
        // Fields.
        private string type;
        private int weight;

        // Properties.
        public string Type { get => this.type; set => this.type = value; }
        public int Weight { get => this.weight; set => this.weight = value; }

        // Constructor.
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
