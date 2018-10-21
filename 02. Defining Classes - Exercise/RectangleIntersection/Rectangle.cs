namespace RectangleIntersection
{
    public class Rectangle
    {
        // Fields.
        private string id;
        private double width;
        private double height;
        private double horizontal;
        private double vertical;

        // Properties.
        public string Id { get => this.id; set => this.id = value; }
        public double Width { get => this.width; set => this.width = value; }
        public double Height { get => this.height; set => this.height = value; }
        public double Horizontal { get => this.horizontal; set => this.horizontal = value; }
        public double Vertical { get => this.vertical; set => this.vertical = value; }

        // Constructor.
        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        // Methods.
        public string FindIntersection(Rectangle secondRec)
        {
            if (this.Horizontal + this.Width < secondRec.Horizontal
                || secondRec.Horizontal + secondRec.Width < this.Horizontal
                || this.Vertical + this.Height < secondRec.Vertical
                || secondRec.Vertical + secondRec.Height < this.Vertical)
            {
                return "false";
            }
            return "true";
        }
    }
}
