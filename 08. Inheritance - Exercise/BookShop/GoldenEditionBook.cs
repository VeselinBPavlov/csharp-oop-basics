namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        // Inherit constructor.
        public GoldenEditionBook(string author, string title, decimal price) 
            : base(author, title, price) 
        {
        }

        // Properties.
        public override decimal Price
        {
            get
            {
                return base.Price * 1.3M;
            }
        }
    }
}
