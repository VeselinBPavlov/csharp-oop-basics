namespace PointInRectangle
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            // Create rectangle.
            var coordinates = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var rectangle = new Rectangle()
            {
                UpperLeft = new Point(coordinates[0], coordinates[1]),
                LowerRight = new Point(coordinates[2], coordinates[3])
            };

            // Check is some point in rectangle.
            var pointsCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < pointsCount; i++)
            {
                var pointArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var point = new Point(pointArr[0], pointArr[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
