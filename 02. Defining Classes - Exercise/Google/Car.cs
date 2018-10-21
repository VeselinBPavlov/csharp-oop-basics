namespace Google
{
    public class Car
    {
        // Fields.
        private string carModel;
        private string carSpeed;

        // Properties.
        public string CarModel { get => carModel; set => carModel = value; }
        public string CarSpeed { get => carSpeed; set => carSpeed = value; }

        // Constructor.
        public Car(string carModel, string carSpeed)
        {
            this.CarModel = carModel;
            this.CarSpeed = carSpeed;
        }

        public Car()
        {
        }

        // Methods.
        public override string ToString()
        {
            if (carModel == null)
            {
                return "";
            }
            return $"\n{this.carModel} {this.carSpeed}";
        }        
    }
}
