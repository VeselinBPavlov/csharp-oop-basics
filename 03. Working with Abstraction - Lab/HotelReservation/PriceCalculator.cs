namespace HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal Calculate(decimal price, int days, Season season, Discount discount)
        {
            return (price * days * (decimal)season) * (1 - (decimal)discount / 100);
        }
    }
}
