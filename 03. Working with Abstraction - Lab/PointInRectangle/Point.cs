namespace PointInRectangle
{
    public class Point
    {
        // Auto properties with initializaion (fields are hide).
        public int PointX { get; set; } = 0;
        public int PointY { get; set; } = 0;

        // Constructor.
        public Point(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }
    }
}
