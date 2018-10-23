namespace RhombusOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                PrintRow(row, size - row);
            }
            for (int row = size; row >= 0; row--)
            {
                PrintRow(row - 1, size - row + 1);
            }
        }

        static void PrintRow(int stars, int whiteSpaces)
        {
            Console.Write(new string(' ', whiteSpaces));
            for (int i = 0; i < stars; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
