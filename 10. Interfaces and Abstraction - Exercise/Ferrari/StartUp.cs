namespace Ferrari
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var driver = Console.ReadLine();
            var ferrarri = new Ferrari(driver);

            Console.WriteLine(ferrarri);
        }
    }
}
