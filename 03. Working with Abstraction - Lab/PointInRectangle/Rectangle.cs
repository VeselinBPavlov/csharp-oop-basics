namespace PointInRectangle
{
    public class Rectangle
    {
        // Auto properties.
        public Point UpperLeft { get; set; }
        public Point LowerRight { get; set; }

        // Methods.
        public bool Contains(Point point)
        {
            var isInHorizontal = 
                point.PointX >= UpperLeft.PointX && 
                point.PointX <= LowerRight.PointX;

            var isInVertical = 
                point.PointY >= UpperLeft.PointY && 
                point.PointY <= LowerRight.PointY;

            return isInHorizontal && isInVertical;
        }
    }
}
