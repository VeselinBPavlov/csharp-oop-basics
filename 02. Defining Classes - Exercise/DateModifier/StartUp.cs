namespace DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var difference = new DateModifier();

            // Take two string dates, parse them and find count of days between them.
            var result = difference.GetDifference(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}
