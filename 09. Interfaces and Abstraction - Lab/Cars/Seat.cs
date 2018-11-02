namespace Cars 
{
    public class Seat : ICar 
    {
        // Properties.
        public string Model { get; set; }
        public string Color { get; set; }

        // Constructor.
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        // Methods.
        public string Start()
        {
            return "Engine start"; 
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model}" +
                $"\n{Start()} " +
                $"\n{Stop()}";
        }
    }
}