namespace RawData
{
    public class Model
    {
        // Fields.
        private string name;

        // Properties.
        public string Name { get => this.name; set => this.name = value; }

        // Constructor.
        public Model(string name)
        {
            this.Name = name;
        }
    }
}
