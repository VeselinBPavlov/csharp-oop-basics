namespace ClassBox
{
    public class Box
    {
        // Fields.
        private double length;
        private double width;
        private double height;

        // Constructor.
        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        // Methods.
        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * width * height);
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        }
    }
}
