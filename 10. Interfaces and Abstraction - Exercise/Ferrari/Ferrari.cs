namespace Ferrari
{
    using System;
    public class Ferrari : ICar
    {
        public string Model { get; set; } = "488-Spider";
        public string Driver { get; set; }

        public Ferrari(string driver) 
        {
            this.Driver = driver;
        }

        public string Break() 
        {
            return "Brakes!";
        }

        public string Accelerate() 
        {
            return "Zadu6avam sA!";
        }

        public override string ToString() 
        {
            return $"{this.Model}/{Break()}/{Accelerate()}/{this.Driver}";
        }
    }
}