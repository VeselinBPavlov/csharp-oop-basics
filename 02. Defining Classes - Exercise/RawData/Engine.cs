namespace RawData
{
    public class Engine
    {
        // Fields.
        private int speed;
        private int power;

        // Properties.
        public int Speed { get => this.speed; set => this.speed = value; }
        public int Power { get => this.power; set => this.power = value; }

        // Constructor.
        public Engine(int speed, int enginePower)
        {
            this.Speed = speed;
            this.Power = enginePower;
        }
    }
}
