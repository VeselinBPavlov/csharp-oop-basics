namespace HotelReservation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var price = decimal.Parse(input[0]);
            var days = int.Parse(input[1]);
            var season = Enum.Parse<Season>(input[2]);
            var discount = input.Length == 4 ? Enum.Parse<Discount>(input[3]) : Discount.None;                

            var result = PriceCalculator.Calculate(price, days, season, discount);

            Console.WriteLine($"{result:f2}");
        }
    }
}
