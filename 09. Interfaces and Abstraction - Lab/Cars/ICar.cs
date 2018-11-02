namespace Cars 
{
    public interface ICar
    {
        // Properties.
        string Model { get; set; }
        string Color { get; set; }

        // Methods.
        string Start();
        string Stop();
    }
}