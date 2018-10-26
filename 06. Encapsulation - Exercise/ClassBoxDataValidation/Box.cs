namespace ClassBoxDataValidation
{
    using System;

    public class Box
    {
        // Fields.
        private double length;
        private double width;
        private double height;

        // Properties.
        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }
        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }

        }
        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        // Constructor.
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
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
